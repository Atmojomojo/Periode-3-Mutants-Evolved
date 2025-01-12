using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Conversationmanager : MonoBehaviour
{
    public bool constart;
    public bool conbool;
    public bool conend;
    public TMP_Text pos;
    public TMP_Text neg;
    public TMP_Text npc;
    public Conversation conversation;
    public GameObject[] buttons;
    public GameObject pressesc;
   
    // Start is called before the first frame update
    void Start()
    {
        constart = false;
        conbool = false;
        npc.text = conversation.questions[0];
        pos.text = conversation.anwsers[0];
        neg.text = conversation.anwsers[1];
        pressesc.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (conbool == true && constart == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                conbool = false;
                conend = true;
            }
        }
    }
    public void Pos()
    {
        npc.text = conversation.questions[1];
        After();    
    }
    public void Neg()
    {
        npc.text = conversation.questions[2];
        After();
    }
    public void After()
    {
        pressesc.SetActive(true);
        for (var i = 0; i < buttons.Length; i++)
        {
            buttons[i].SetActive(false);
        }
        constart = false;
    }
}

