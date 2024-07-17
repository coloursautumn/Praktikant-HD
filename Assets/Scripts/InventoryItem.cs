using AYellowpaper.SerializedCollections;
//using System.Collections;
//using System.Collections.Generic;
//using System.IO.Pipes;
using UnityEditor;
using UnityEngine;
//using UnityEngine.Rendering;
using static AYellowpaper.SerializedCollections.SerializedDictionarySample;

public class InventoryItem : MonoBehaviour
{
    public string _ItemName;
    [SerializedDictionary("Исходник", "Результат")]
    public SerializedDictionary<string, InventoryItem> _recipes;// = new SerializedDictionary<string, InventoryItem>();
    private Inventory _inventory;

    private void Start()
    {
        _inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
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

    //public void Give(Npc target)
    //{
           // Передаём предмет NPC и пусть он разбирается, что с ним делать.
    //}

    public void PassToInventory()
    {
        _inventory.HandleClick(this);
    }
}