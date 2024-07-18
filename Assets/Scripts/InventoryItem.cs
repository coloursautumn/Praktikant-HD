using AYellowpaper.SerializedCollections;
//using System.Collections;
//using System.Collections.Generic;
//using System.IO.Pipes;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
//using UnityEngine.Rendering;
using static AYellowpaper.SerializedCollections.SerializedDictionarySample;

public class InventoryItem : MonoBehaviour//, IPointerEnterHandler, IPointerExitHandler
{
    public string _ItemName;
    Tooltip _tooltip;
    [SerializedDictionary("Исходник", "Результат")]
    public SerializedDictionary<string, InventoryItem> _recipes;// = new SerializedDictionary<string, InventoryItem>();
    private Inventory _inventory;

    private void Start()
    {
        _inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
        //_tooltip = GameObject.FindGameObjectWithTag("Tooltip").GetComponent<Tooltip>();
    }

    public void PrintName()
    {
        //print(_ItemName);
        print(this._ItemName);
    }

    public void Mix(InventoryItem other)
    {
        //other = ContainsKey(recipes key);
        bool validRecipe;
        validRecipe = _recipes.ContainsKey(other._ItemName);
        Debug.Log("Пытаемся смешать " + this._ItemName + " и " + other._ItemName + ": " + validRecipe);
        if (validRecipe == true)
        {
            Instantiate(_recipes[other._ItemName], _inventory.inventoryGrid.transform);
            Destroy(other.gameObject); 
            Destroy(gameObject);


        }
        // Если предмет можно совместить с other, делаем это!
        // Если нельзя, то не делаем ничего и по возможности оповещаем игрока.
    }

    public void EmptyOut()
    {
        // Если это производная от контейнера, её уничтожаем и создаём пустой контейнер (кржуку, ведро, и т. п.) 
    }

    public void Give(NPC target)
    {
        //Передаём предмет NPC и пусть он разбирается, что с ним делать.
        //print("Пытаемся передать персонажу " + target + " предмет " + _ItemName);
        target.TurnInQuest(this);
    }

    public void PassToInventory()
    {
        _inventory.HandleClick(this);
    }

    //public void OnPointerEnter(PointerEventData eventData)
    //{
    //    _tooltip.enabled = true;
    //    _tooltip.ChangeText(_ItemName);
    //}

    //public void OnPointerExit(PointerEventData eventData)
    //{
    //    _tooltip.enabled = false;
    //}
    //public void OnPointerDown(PointerEventData eventData)
    //{

    //}
}