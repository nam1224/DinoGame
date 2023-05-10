using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject bg;
    public Animator animator;
    public GameObject gamePanel;
    public GameObject finishPanel;
    public GameObject startPanel;
    public void ManagePanel(int num)
    {
        switch(num)
        {
            case 1: //시작 화면
                startPanel.SetActive(true);
                gamePanel.SetActive(false);
                finishPanel.SetActive(false);
                break;

            case 2: //게임 화면
                startPanel.SetActive(false);
                gamePanel.SetActive(true);
                finishPanel.SetActive(false);
                break;

            case 3: //종료 화면
                startPanel.SetActive(false);
                gamePanel.SetActive(false);
                finishPanel.SetActive(true);
                
                break;

            default: //기본
                startPanel.SetActive(false);
                gamePanel.SetActive(true);
                finishPanel.SetActive(false);
                break;
        }
    }

    void MoveBackground()
    {

    }

    public void RestartGame() //다시 시작
    {
        SceneManager.LoadScene("project1");
    }

    DataSave dataSave;
    private void Start()
    {
        ManagePanel(0);
        dataSave = GetComponent<DataSave>();
    }
}
