using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGManager : MonoBehaviour
{
    public CanvasManager canvasManager;

    void Start()
    {
        canvasManager = GetComponent<CanvasManager>();
    }



    void Update()
    {
        Debug.Log("현재 BGManager script에서 실행중 : " + canvasManager.textScore);
    }
}
