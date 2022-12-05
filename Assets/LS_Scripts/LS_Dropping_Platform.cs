using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LS_Dropping_Platform : MonoBehaviour
{
    public float timeBeforeFalling;
    
    private float timeToSwitch;
    private bool touched = false;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(touched && timeToSwitch < Time.time)
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            rb.gravityScale = 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Started");

            touched = true;
            timeToSwitch = Time.time + timeBeforeFalling;
        }
    }
}
