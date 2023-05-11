using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // Serializable
using System.IO;

//������ ���� -> ������ �ҷ����� -> ������ 
[Serializable]
public class PlayerData
{
    public int score;
    public void GetData()
    {
        CanvasManager cvMg = GameObject.Find("Canvas").GetComponent<CanvasManager>();
        cvMg.textFinalScore.text = score.ToString();
        Debug.Log(cvMg.stackScore);
    }
}

public class DataSave : MonoBehaviour
{
    //������ ���� -> 
    private void Start()
    {

    }
    public void SaveData()
    {
        PlayerData myData = new PlayerData();
        CanvasManager cvMg = GameObject.Find("Canvas").GetComponent<CanvasManager>();

        myData.score = cvMg.stackScore;
        Debug.Log(myData.score);
        string str = JsonUtility.ToJson(myData);

        //Debug.Log(str);

        File.WriteAllText(Application.persistentDataPath +
            "/PlayerData.json", JsonUtility.ToJson(myData));
        Debug.Log("Save");
    }

    public void loadData()
    {
        try
        {
            string jsonData = File.ReadAllText(Application.persistentDataPath + "/PlayerData.json");
            Debug.Log(jsonData);
            PlayerData myData = JsonUtility.FromJson<PlayerData>(jsonData);
            myData.GetData();
        }
        catch(Exception)
        {
            SaveData();
        }
        
    }
}
