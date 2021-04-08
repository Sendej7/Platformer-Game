using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public int ID;
    public PlayerMovement PlayerMovement;
    bool ChestOpened;
    public Animator animator;
    public GameObject ChestManagerGO;
    public ChestManager ChestManager;
    void Start()
    {
        ChestManagerGO = GameObject.Find("ChestManager"); 
        ChestManager= ChestManagerGO.GetComponent<ChestManager>();
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(ChestOpened==true)
        {
            PlayerMovement.TextOnPlayerHead.text = "";
        }
        else
        {
            PlayerMovement.TextOnPlayerHead.text = "Press e to open chest";
        }
        
    }
    private void OnTriggerStay2D(Collider2D other) 
    {
        if(Input.GetKey("e"))
        {
            if(ChestOpened==true)
            {
                PlayerMovement.TextOnPlayerHead.text = "";
            }
            else
            {
                animator.SetBool("ChestOpened", true);
                PlayerMovement.TextOnPlayerHead.text = "";
                ChestOpened=true;
                ChestManager.AwardFromChest(ID);
            }
        }
    }

    
}
