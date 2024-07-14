using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<InventoryItem> Items = new List<InventoryItem>();
    private Canvas canvas;
    [SerializeField] public GridLayoutGroup inventoryGrid;

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
