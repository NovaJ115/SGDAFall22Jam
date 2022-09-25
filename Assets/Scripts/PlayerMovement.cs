using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Camera cam;
    public float numHealth = 3;
    private float nextDash;
    private float dashCooldown = 2f;
    public bool invincible = false;
    public Transform playerEric;

    Vector2 movement;
    Vector2 mousePos;

    void Start()
    {
        nextDash = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(TurnInvincibleHit());
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetButtonDown("Fire2") && Time.time > nextDash)
        {
            //rb.AddForce(playerEric.up * 100, ForceMode2D.Impulse);
            StartCoroutine(Dash());
            //rb.MovePosition(rb.position + movement * 100 * Time.fixedDeltaTime);
            nextDash = Time.time + dashCooldown;

        }
    }


    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    public IEnumerator TurnInvincibleHit()
    {

        invincible = true;

        yield return new WaitForSeconds(0.5f);

        invincible = false;
        StopAllCoroutines();

        yield return null;

    }
    public IEnumerator Dash()
    {

        invincible = true;
        moveSpeed = 20f;
        yield return new WaitForSeconds(0.1f);

        invincible = false;
        moveSpeed = 5f;
        StopAllCoroutines();
        yield return null;

    }

    public void turnInvincible2()
    {
        StartCoroutine(TurnInvincibleHit());
    }

    public float getHealth()
    {
        return numHealth;
    }
}
