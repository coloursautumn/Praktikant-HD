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
        //canvas = GetComponent<Canvas>(); //Получение компонента Canvas
        //canvas.enabled = false; //Отключение инвентаря при старте
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            canvas.enabled = !canvas.enabled; //При нажатии на кнопку I окно будет отображаться или скрываться

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
