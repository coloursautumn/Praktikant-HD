using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<InventoryItem> Items = new List<InventoryItem>();
    private Canvas canvas;
    [SerializeField] public GridLayoutGroup inventoryGrid;
    public bool _selectobject;
    public InventoryItem _activeobject;


    void Start()
    {
        //canvas = GetComponent<Canvas>(); //��������� ���������� Canvas
        //canvas.enabled = false; //���������� ��������� ��� ������
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            canvas.enabled = !canvas.enabled; //��� ������� �� ������ I ���� ����� ������������ ��� ����������

        }
    }
    public void HandleClick(InventoryItem _object)
    {
        _selectobject = true;
        _activeobject = _object;
        print(_activeobject);
        print(_object);



    }




}
