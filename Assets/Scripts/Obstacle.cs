using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Player pl;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        pl = collision.GetComponent<Player>();
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player�� Obstacle�� �浹");
            pl.heart++;
            Destroy(this.gameObject);
            Debug.Log("�ε��� Ƚ�� : "+ pl.heart);
        }

        if (collision.gameObject.CompareTag("Land"))
        {
            Debug.Log("Land�� Obstacle�� �浹");
            Destroy(this.gameObject);
        }
    }
}
