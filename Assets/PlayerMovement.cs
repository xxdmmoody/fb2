using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform player;
    public Rigidbody2D rb;
    private Animator anim;
    private bool isDead = false;
    public float flapPower = 200f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (isDead == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetTrigger("Flap");
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0, flapPower));
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity = Vector2.zero;
        isDead = true;
        GameManager.instance.birdDied();
    }
}
