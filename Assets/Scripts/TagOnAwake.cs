using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagOnAwake : MonoBehaviour
{
    [SerializeField] string _tag;
    private void Awake()
    {
        gameObject.tag = _tag;
    }
}
