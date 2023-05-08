using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Image ImgHeart1; //마지막
    public Image ImgHeart2; //두 번째
    public Image ImgHeart3; //가장 먼저

    void Start()
    {
        Obstacle ob = new Obstacle();
    }

    void Update()
    {
    }
}
