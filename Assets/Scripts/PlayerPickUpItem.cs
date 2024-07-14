using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerPickUpItem : MonoBehaviour
{
    [SerializeField] Inventory inventory;
    //private PlayerPickUpItem InventoryItem;

    private item _activeObject;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<item>() != null)
        {
            _activeObject = collision.GetComponent<item>();
            print("Нажмите E/ЛКМ чтобы подобрать " + _activeObject.name);

        }
    }
    public void Update()
    {
        if (_activeObject != null && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0)))
        {
            print("Вы подобрали " + _activeObject.name);
            //inventory.Items.Add(_activeObject.inventoryItem);
            //print(inventory.Items[0]._ItemName);
            Instantiate(_activeObject.inventoryItem, inventory.inventoryGrid.transform);
            //print(inventory.Items);
            Destroy(_activeObject.transform.gameObject);

        }
        if (_activeObject == null && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0)))
            {
                print("Поблизости нет предметов для подбора");
            }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (_activeObject != null)
        {
            _activeObject = null;
            print("Вы ничего не подобрали");
        }
    }

}
