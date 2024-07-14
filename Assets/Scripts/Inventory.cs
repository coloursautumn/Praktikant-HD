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
        canvas = GetComponent<Canvas>(); //Получение компонента Canvas
        canvas.enabled = false; //Отключение инвентаря при старте
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            canvas.enabled = !canvas.enabled; //При нажатии на кнопку I окно будет отображаться или скрываться

        }
    }
    
}
