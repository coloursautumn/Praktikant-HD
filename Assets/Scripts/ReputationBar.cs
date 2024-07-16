using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class ReputationBar : MonoBehaviour
{
    public float _reputation;
    public float _maxreputation = 100;

    Image _reputationBar;
    // Start is called before the first frame update
    void Start()
    {
        _reputationBar = GetComponent<Image>();
        _reputation = 50;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _reputation -= 5;
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            _reputation += 5;
        }

        _reputationBar.fillAmount = _reputation / _maxreputation;
    }
}
