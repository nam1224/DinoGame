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

    public void DiePlayer(int heart)
    {
        GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        if (heart >= 3)
        {
            animator.SetBool("anim_death", true);
            isGameOver = true;
            gm.ManagePanel(3);
            //Debug.Log(isGameOver);
        }
    }

    public void Skill()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("anim_attack");
            Destroy(GameObject.FindGameObjectsWithTag("Obstacle").Min());
            animator.SetTrigger("anim_run");
            //Debug.Log("adfjlkjf;lajf;ldaj;alkd");
        }
        //Debug.Log("Skill 호출");
        //List<GameObject> enemies = new List<GameObject>();
        //GameObject closestEnemy = enemies.OrderBy(e => Mathf.Sqrt(Mathf.Pow(enemyArray[0].transform.position.x - player.transform.position.x, 2) + Mathf.Pow(enemyArray[0].transform.position.y - player.transform.position.y, 2))).FirstOrDefault();
        //Debug.Log(closestEnemy);
       
        //Debug.Log("Skill 호출 완");
    }

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        //Debug.Log("현재 목숨 수 :" + heart);
    }


    void Update()
    {
        Jump();
        Skill();
    }
}
