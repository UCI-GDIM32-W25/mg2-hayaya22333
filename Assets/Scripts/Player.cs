using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] public float jumpForce = 5f;
    [SerializeField] public bool isGrounded = true;
    [SerializeField] private PointText _pointText;
    private int coinNum = 0;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown("space") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Collectible"){
            coinNum += 1;
            _pointText.UpdatePointText(coinNum);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") isGrounded = true;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") isGrounded = false;
    }

    
}
