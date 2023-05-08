using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int heart = 3; //Player狼 格见
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player客 Obstacle捞 面倒");
            Destroy(this.gameObject);
            heart--;
        }

        if (collision.gameObject.CompareTag("Land"))
        {
            Debug.Log("Land客 Obstacle捞 面倒");
            Destroy(this.gameObject);
        }
    }
}
