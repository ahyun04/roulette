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
        //1. ȭ�� ������ 
        bool isDown = Input.GetMouseButtonDown(0);
        bool isDown2 = Input.GetMouseButtonDown(1);

        if(isDown)
        {
            Debug.Log("�������� �������ϴ�");
            rotationSpeed = 10;
        }

        if(isDown2)
        {
            Debug.Log("���������� �������ϴ�");
            rotationSpeed = 10;
        }

        //2. ȸ�� ���??
        this.transform.Rotate(0, 0, rotationSpeed);

        //�ӵ� ���̰�
        //rotationSpeed *= 0.96f;
        rotationSpeed = rotationSpeed * 0.96f;
        Debug.Log(rotationSpeed);
    }
}
