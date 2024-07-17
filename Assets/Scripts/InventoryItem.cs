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
    [SerializedDictionary("��������", "���������")]
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
        Debug.Log("�������� ������� " + this._ItemName + " � " + other._ItemName + ": " + validRecipe);
        if (validRecipe == true)
        {
            Instantiate(_recipes[other._ItemName], _inventory.inventoryGrid.transform);
            Destroy(other.gameObject); 
            Destroy(gameObject);


        }
        // ���� ������� ����� ���������� � other, ������ ���!
        // ���� ������, �� �� ������ ������ � �� ����������� ��������� ������.
    }

    public void EmptyOut()
    {
        // ���� ��� ����������� �� ����������, � ���������� � ������ ������ ��������� (������, �����, � �. �.) 
    }

    //public void Give(Npc target)
    //{
           // ������� ������� NPC � ����� �� �����������, ��� � ��� ������.
    //}

    public void PassToInventory()
    {
        _inventory.HandleClick(this);
    }
}