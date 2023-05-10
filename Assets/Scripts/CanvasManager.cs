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
        textScore.text = "0";
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
    public int stackScore = 0;
    public int scorePlus = 1; //이거 건드려서 점수 증가량 조절
    void Score() //Score를 관리
    {
        
        time += Time.deltaTime;
        if (time >= 1)
        {
            stackScore += scorePlus;
            textScore.text = stackScore.ToString();
            time = 0;
        }
    }

    public Text textFinalScore;
    public Text textMyScore;

    float time;
    void Update()
    {

        ShowHeart();
        Score();
    }
}
