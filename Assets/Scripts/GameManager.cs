using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    Player pl;
    public Image[] imgHeart = new Image[3];

    void Start()
    {
        pl = GameObject.Find("Player").GetComponent<Player>();
    }

    void Update()
    {

    }
}
