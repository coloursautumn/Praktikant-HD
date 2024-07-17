using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    [SerializeField] private Transform _PanelInventory;
    [SerializeField] private Transform _PanelTasks;
    [SerializeField] private Transform _PanelDeals;
    [SerializeField] private Transform _PanelClosed;
    [SerializeField] private Transform _activepanel;

    // Start is called before the first frame update
    void Start()
    {
        _PanelInventory.gameObject.SetActive(false);
        _PanelTasks.gameObject.SetActive(false);
        _PanelDeals.gameObject.SetActive(false);
        _PanelClosed.gameObject.SetActive(true);
    }

    public void SwitchActivePanel(Transform _switcher)
    {
        //print("Мы нажали "+  _switcher.name);
        if (_activepanel == _switcher)
        {
            _activepanel.gameObject.SetActive(false);
            _PanelClosed.gameObject.SetActive(true);
            _activepanel = null;
        }
        else
        {
            if (_activepanel != null)
            {
                _activepanel.gameObject.SetActive(false);
                _PanelClosed.gameObject.SetActive(false);
            }
            _switcher.gameObject.SetActive(true);
            _activepanel = _switcher;
            _PanelClosed.gameObject.SetActive(false);
        }
    }
    
}
