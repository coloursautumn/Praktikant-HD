using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScale : MonoBehaviour
{
    private RectTransform _rectTransform;

    void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        var scale = Screen.height * 0.5f / 851;
        _rectTransform.localScale = new Vector3(scale, scale, scale);
    }
}
