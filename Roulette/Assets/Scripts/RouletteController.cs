using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    private float rotationSpeed = 0f;
    void Start()
    {
        
    }

    void Update()
    {
        //1. 화면 누르기 
        bool isDown = Input.GetMouseButtonDown(0);
        bool isDown2 = Input.GetMouseButtonDown(1);

        if(isDown)
        {
            Debug.Log("왼쪽으로 눌렀습니다");
            rotationSpeed = 10;
        }

        if(isDown2)
        {
            Debug.Log("오른쪽으로 눌렀습니다");
            rotationSpeed = 10;
        }

        //2. 회전 어떻게??
        this.transform.Rotate(0, 0, rotationSpeed);

        //속도 줄이고
        //rotationSpeed *= 0.96f;
        rotationSpeed = rotationSpeed * 0.96f;
        Debug.Log(rotationSpeed);
    }
}
