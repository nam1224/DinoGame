using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    private Rigidbody2D rb2D;
    public float movementSpeed = 5f;

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Click Complete");
            rb2D.AddForce(transform.up * 100);
            //player.transform.position = new Vector2(player.transform.position.x, movementSpeed * Time.deltaTime);
        }
    }
    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Jump();
    }
}
