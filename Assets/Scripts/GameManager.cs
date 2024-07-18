using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] int _questsOnLevel;
    int _questsLeft;
    [SerializeField] Image _gameWinScreen;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        _questsLeft = _questsOnLevel;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void FinishQuest()
    {
        _questsLeft--;
        if (_questsLeft <= 0)
        {
            print("Ещё один день пережит!");
            _gameWinScreen.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();
        }
    }
}
