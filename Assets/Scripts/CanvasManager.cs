using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    Player pl;
    public GameObject[] imgHeart = new GameObject[3];

    void Start()
    {
        pl = GameObject.Find("Player").GetComponent<Player>();
    }
        
    void ShowHeart()
    {
        switch (pl.heart)
        {
            case 1:
                imgHeart[0].SetActive(false);
                break;

            case 2:
                imgHeart[1].SetActive(false);
                break;

            case 3:
                imgHeart[2].SetActive(false);
                break;

            default:
                break;
        }
    }
    
    public Text textScore;
    void Score() //Score¸¦ °ü¸®
    {
        textScore.text += Time.deltaTime * 0.1f;
    }

    void Update()
    {
        ShowHeart();
        Score();
    }
}
