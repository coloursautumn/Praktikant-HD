using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MovementOnStairs : MonoBehaviour
{
    [SerializeField] private UnityEvent<GameObject> _actionObject;
    public bool _ladder;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player"))
        {

            _actionObject?.Invoke(collision.gameObject);
            _ladder = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _ladder = false;
        
    }
    

}
