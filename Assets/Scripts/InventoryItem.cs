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

    public void PrintName()
    {
        //print(_ItemName);
        print(this._ItemName);
    }

    public void Mix (InventoryItem other)
    {
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

}