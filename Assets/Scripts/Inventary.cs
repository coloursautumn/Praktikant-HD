using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slot : MonoBehaviour
{
    private Canvas canvas;

    void Start()
    {
        canvas = GetComponent<Canvas>(); //��������� ���������� Canvas
        canvas.enabled = false; //���������� ��������� ��� ������
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            canvas.enabled = !canvas.enabled; //��� ������� �� ������ I ���� ����� ������������ ��� ����������
        }


    }
}
