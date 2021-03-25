using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NPC : MonoBehaviour
{
    public PlayerMovement PlayerMovement;
    public GameObject NPCTextGO;
    public TMP_Text NPCText;
    public bool TalkStarted;
    public GameObject NPCGO;
    public PlayerManager PlayerManager;
    int AngryNPC;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        NPCTextGO.SetActive(true);
        
        if(TalkStarted==true)
        {
            Talk(AngryNPC); 
            Debug.Log(AngryNPC);
        }
        else
        {
            PlayerMovement.TextOnPlayerHead.text = "Press e to talk";
        }
    }
    private void OnTriggerExit2D(Collider2D other) 
    {
        NPCTextGO.SetActive(false);
        PlayerMovement.TextOnPlayerHead.text = "";
        if(TalkStarted==true)
        {
            AngryNPC+=1;
        }
    }
    private void OnTriggerStay2D(Collider2D other) 
    {
        if(Input.GetKey("e"))
        {
            if(TalkStarted==true)
            {
                Talk(AngryNPC); 
            }
            else
            {
                Talk(0);
            }
        }
    }
    public void Talk(int i)
    {
        switch (i)
        {
            case 0:
            NPCText.text= "Monsters attacked me and took my gold. Can you help me?";
            PlayerMovement.TextOnPlayerHead.text = "Help him";
            TalkStarted=true;
            break;
            case 1:
            NPCText.text= "Monsters attacked me and took my gold. Can you help me?";
            PlayerMovement.TextOnPlayerHead.text = "Help him";
            TalkStarted=true;
            break;
            case 2:
            NPCText.text= "Child are you going to help me?";
            PlayerMovement.TextOnPlayerHead.text = "Help him";
            TalkStarted=true;
            break;
            case 3:
            NPCText.text= "Child what are you doing?";
            PlayerMovement.TextOnPlayerHead.text = "Help him";
            TalkStarted=true;
            break;
            case 4:
            NPCText.text= "Child are you blind?";
            PlayerMovement.TextOnPlayerHead.text = "Help him";
            TalkStarted=true;
            break;
            case 5:
            NPCText.text= "So you are not going to help me?";
            PlayerMovement.TextOnPlayerHead.text = "Help him";
            TalkStarted=true;
            break;
            case 6:
            NPCText.text= "You are very bad person you know that?";
            PlayerMovement.TextOnPlayerHead.text = "Help him";
            TalkStarted=true;
            break;
            case 7:
            NPCText.text= "Child please. I need that gold for my family";
            PlayerMovement.TextOnPlayerHead.text = "Help him";
            TalkStarted=true;
            break;
            case 8:
            NPCText.text= "If I don't buy the medicine my daughter will die";
            PlayerMovement.TextOnPlayerHead.text = "Help him";
            TalkStarted=true;
            break;
            case 9:
            NPCText.text= "I see that you don't care. I will remember that";
            PlayerMovement.TextOnPlayerHead.text = "Help him";
            TalkStarted=true;
            break;
            case 10:
            NPCText.text= "Last chance are you going to help me?";
            PlayerMovement.TextOnPlayerHead.text = "Help him";
            TalkStarted=true;
            break;
            case 11:
            NPCGO.SetActive(false);
            PlayerManager.reputation-=1;
            Debug.Log(PlayerManager.reputation);
            break;
        }
    }

}
