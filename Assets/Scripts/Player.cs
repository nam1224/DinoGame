using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float power = 350;
    public int heart = 0;
    private bool isJumping = true;
    public bool isGameOver = false;

    Animator animator;
    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (isJumping == false)
            {
                rb2D.AddForce(transform.up * power);
                isJumping = true;
                animator.SetBool("anim_jump", true);
            }
            else return;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Land"))
        {
            isJumping = false;
            animator.SetBool("anim_jump", false);
        }
    }

    DataSave dataSave;
    public void DiePlayer(int heart)
    {
        GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        if(heart >= 3)
        {
            animator.SetBool("anim_death", true);
            isGameOver = true;
            gm.ManagePanel(3);
            //Debug.Log(isGameOver);
        }
    }

    public void Skill(GameObject[] enemy)
    {
        foreach()
        {

        }
    }

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>(); //��script(Player)�� ���� object�� Rigidbody�� ������
        animator = GetComponent<Animator>();
        Debug.Log("���� ��� �� :" + heart);
    }


    void Update()
    {
        Jump();
        
    }
}
