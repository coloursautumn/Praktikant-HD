using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tooltip : MonoBehaviour
{
    [SerializeField] TMP_Text _text;

    public void ChangeText(string newText)
    {
        _text.text = newText;
    }
    public void Update()
    {
        transform.position = Input.mousePosition + Vector3.up * 10;
    }
}
