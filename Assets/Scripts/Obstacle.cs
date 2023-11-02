using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Player pl;
    Rigidbody2D rb2D;
    RepeatBg repeatBg;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        pl = collision.GetComponent<Player>();
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Player�� Obstacle�� �浹");
            pl.heart++;
            pl.DiePlayer(pl.heart);
            Destroy(this.gameObject);
            //Debug.Log("�ε��� Ƚ�� : "+ pl.heart);
        }

        if (collision.gameObject.CompareTag("Land"))
        {
            //Debug.Log("Land�� Obstacle�� �浹");
            Destroy(this.gameObject);
        }
    }

    public float speed = 3.5f;
    void MoveObstacle()
    {
        repeatBg = GameObject.Find("cloud").GetComponent<RepeatBg>();
        pl = GameObject.Find("Player").GetComponent<Player>();
        rb2D = GetComponent<Rigidbody2D>();
        if (pl.isGameOver == false)
        {
            rb2D.velocity = Vector2.right * (speed + repeatBg.adjustSpeed(speed));
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        MoveObstacle();
    }
}
