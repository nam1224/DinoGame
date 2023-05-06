using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private GameObject player;
    public Rigidbody2D rb2D;
    public float power = 350;
    bool isJumping = true;

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (isJumping == false)
            {
                Debug.Log("Click Complete");
                rb2D.AddForce(transform.up * power);
                //player.transform.position = new Vector2(player.transform.position.x, movementSpeed * Time.deltaTime);
                isJumping = true;
            }
            else return;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("충돌 중");
        if (collision.gameObject.CompareTag("Land"))
            isJumping = false;
    }

    void Slide()
    {
        
    }

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>(); //이script(Player)를 가진 object의 Rigidbody를 가져옴
    }


    void Update()
    {
        Jump();
    }
}
