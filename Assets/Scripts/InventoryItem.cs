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
    [SerializedDictionary("��������", "���������")]
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

    public void Give(NPC target)
    {
        //������� ������� NPC � ����� �� �����������, ��� � ��� ������.
        //print("�������� �������� ��������� " + target + " ������� " + _ItemName);
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