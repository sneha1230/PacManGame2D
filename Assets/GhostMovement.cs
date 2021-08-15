using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GhostMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public int GhostSpeed=10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x <= -33)
        {
            GhostSpeed = 10;
        }
        if (transform.position.x >= 59)
        {
            GhostSpeed = -10;
        }
        transform.Translate(GhostSpeed * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            Destroy(collision.gameObject);
        }

    }



}
