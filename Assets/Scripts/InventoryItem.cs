using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    public string _ItemName;

    public void PrintName()
    {
        print(_ItemName);
    }
}