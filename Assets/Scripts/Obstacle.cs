using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int heart = 3; //Player�� ���
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player�� Obstacle�� �浹");
            Destroy(this.gameObject);
            heart--;
        }

        if (collision.gameObject.CompareTag("Land"))
        {
            Debug.Log("Land�� Obstacle�� �浹");
            Destroy(this.gameObject);
        }
    }
}
