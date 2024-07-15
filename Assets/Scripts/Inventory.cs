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
    InventoryItem _targetobject;


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
        if (_selectobject == false)
        {
            {
                _selectobject = true;
                _activeobject = _object;
            }
        }
       
        else if (_selectobject == true)
        {
            _targetobject = _object;
            _targetobject.Mix(_activeobject);
            _selectobject = false;
            _activeobject = null;
            _targetobject = null;
        }
    }




}
