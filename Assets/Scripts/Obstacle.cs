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
            Debug.Log("Player客 Obstacle捞 面倒");
            Destroy(this.gameObject);
            pl.heart++;
            Debug.Log(pl.heart);
        }

        if (collision.gameObject.CompareTag("Land"))
        {
            Debug.Log("Land客 Obstacle捞 面倒");
            Destroy(this.gameObject);
        }
    }
}
