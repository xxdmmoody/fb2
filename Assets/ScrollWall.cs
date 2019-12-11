using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollWall : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(GameManager.instance.scrollSpeed *-1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.gameOver == true)
        {
            rb.velocity = Vector2.zero;
        }
    }
}
