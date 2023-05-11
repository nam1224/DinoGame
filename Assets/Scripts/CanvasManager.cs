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
    
    public Text textScore; //gamePanel
    public int stackScore = 0;
    public int scorePlus = 1;
    float time;
    DataSave data;
    void Score() //Score를 관리
    {
        pl = GameObject.Find("Player").GetComponent<Player>();
        data = GameObject.Find("GameManager").GetComponent<DataSave>();
        time += Time.deltaTime;
        if (time >= 0.35 && pl.isGameOver == false)
        {
            stackScore += scorePlus;
            textScore.text = stackScore.ToString();
            time = 0;
        }
        SaveSocre();
    }

    bool isSave = true;
    void SaveSocre()
    {
        
        if (isSave == true && pl.isGameOver == true)
        {
            textMyScore.text = stackScore.ToString();
            data.loadData();
            data.SaveData();
            isSave = false;
        }
    }

    public Text textFinalScore; //전판 점수
    public Text textMyScore; //이번판 점수

    void Update()
    {
        ShowHeart();
        Score();
    }
}
