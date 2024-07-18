using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    public List<Missions> _missions = new List<Missions>();
    public GridLayoutGroup GridQuest;
    public ReputationBar _reputation;

    public Missions _activeQuest;

    // Start is called before the first frame update
    void Start()
    {
        _reputation = GameObject.FindGameObjectWithTag("ReputationBar").GetComponent<ReputationBar>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        GiveQuest();
    }

    public void GiveQuest()
    {
        if (_missions.Count > 0)
        {
            _activeQuest = Instantiate(_missions[0].gameObject, GridQuest.gameObject.transform).GetComponent<Missions>();
            print(_activeQuest._startDiaogue);
            _missions.RemoveAt(0);
        }
    }
    public void TurnInQuest(InventoryItem item)
    {
        if (item._ItemName == _activeQuest._finishitem._ItemName)
        {
            //Ввыдать выигрышный диалог
            print(_activeQuest._winDialogue);
            // Начислить репутацию
            _reputation.AddReputation(10f);
            // Уничтожить квест в журнале
            Destroy(_activeQuest.gameObject);
            // Обнулить активквест
            _activeQuest = null;
            // Уничтожить предмет из инвентаря
            Destroy(item.gameObject);
        }
        else
        {
            // Выдать плохой диалог
            print(_activeQuest._failDialogue);
            // Списать репутацию
            _reputation.SubtractReputation(5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
