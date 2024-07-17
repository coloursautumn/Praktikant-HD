using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour


{
    public Transform _activepanel;
    private Canvas canvas;
    private Inventory _inventory;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponentInParent<Canvas> (); //Получение компонента Canvas
        canvas.enabled = false; //Отключение инвентаря при старте
        _inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            canvas.enabled = !canvas.enabled; //При нажатии на ЛКМ окно будет отображаться или скрываться


        }
    }
}
