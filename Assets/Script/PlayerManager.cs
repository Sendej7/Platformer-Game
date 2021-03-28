using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float reputation;
    public PlayerMovement PlayerMovement;
    float timer;
    public float PlayerHP;
    public float PlayerGold;
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
    }
    public void LoseHP(int Amount)
    {
        PlayerMovement.animator.SetBool("IsPlayerReceiveDamage", true);
        timer=0.01f;
    }
}
