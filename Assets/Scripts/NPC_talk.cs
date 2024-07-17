using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_talk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        print("Эй, Тимош, принеси-ка мне чайку, а то у меня водоросли скоро в трубочку скрутятся.»");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
