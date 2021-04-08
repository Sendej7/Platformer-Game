using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerManager : MonoBehaviour
{
    public float reputation;
    public PlayerMovement PlayerMovement;
    float timer, TextTime;
    public float PlayerHP;
    public float PlayerGold;
    public TMP_Text TextOnUI;
    public GameObject TextOnUIGO;
    void Update()
    {
        if(timer>=0)
        {
            timer-= Time.deltaTime;
            if(timer<=0)
            {
                PlayerMovement.animator.SetBool("IsPlayerReceiveDamage", false);
            }
        }
        if(TextTime>=0)
        {
            TextTime-=Time.deltaTime;
            if(TextTime<=0)
            {
                TextOnUI.text = "";
            }
        }
    }
    public void LoseHP(int Amount)
    {
        PlayerMovement.animator.SetBool("IsPlayerReceiveDamage", true);
        timer=0.01f;
    }
    public void AddGold(int GoldAmount)
    {
        TextOnUIGO.SetActive(true);
        TextOnUI.text = "You received: " + GoldAmount + " gold";
        PlayerGold+=GoldAmount;
        TextTime=1.5f;
    }
}
