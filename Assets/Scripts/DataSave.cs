using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // Serializable
using System.IO;

//데이터 저장 -> 데이터 불러오기 -> 데이터 
[Serializable]
public class PlayerData
{
    public int score;
    public void GetData()
    {
        CanvasManager cvMg = GameObject.Find("CanvasManager").GetComponent<CanvasManager>();
        cvMg.textFinalScore.text = score.ToString();
    }
}

public class DataSave : MonoBehaviour
{
    //데이터 저장 -> 
    private void Start()
    {
        //SaveData();
    }
    public void SaveData()
    {
        PlayerData myData = new PlayerData();
        CanvasManager cvMg = new CanvasManager();

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
        string stringjsonData = File.ReadAllText(Application.persistentDataPath + "/PlayerData.json");

        PlayerData data2 = JsonUtility.FromJson<PlayerData>(stringjsonData);
        data2.GetData();
        //Debug.Log("Load");
    }
}
