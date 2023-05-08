using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private GameObject player;
    public Rigidbody2D rb2D;
    public float power = 350;
    public int heart = 0;
    bool isJumping = true;

    Animator animator;
    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (isJumping == false)
            {
                rb2D.AddForce(transform.up * power);
                isJumping = true;
                animator.SetBool("anim_Jump", true);
            }
            else return;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Land"))
        {
            isJumping = false;
            animator.SetBool("anim_Jump", false);
        }
    }

    void Slide()
    {
        
    }

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>(); //��script(Player)�� ���� object�� Rigidbody�� ������
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        Jump();
    }
}
