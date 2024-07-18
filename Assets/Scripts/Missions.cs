using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missions : MonoBehaviour
{
    public InventoryItem _finishitem;
    public NPC _npc;
    public string _startDiaogue;
    public string _winDialogue;
    public string _failDialogue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FinishQuest() 
    {

       Destroy(gameObject);
    }
}
