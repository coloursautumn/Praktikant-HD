using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class ReputationBar : MonoBehaviour
{
    public float _reputation;
    public float _maxreputation = 100;
    [SerializeField] Image _gameOverScreen;

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
            SubtractReputation(100f);
        }
        _reputationBar.fillAmount = _reputation / _maxreputation;
    }

    public void AddReputation (float rep)
    {
        _reputation += rep;
    }

    public void SubtractReputation(float rep)
    {
        _reputation -= rep;
        if (_reputation <= 0)
        {
            _gameOverScreen.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
