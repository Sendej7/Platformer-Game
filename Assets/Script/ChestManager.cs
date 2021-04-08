using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestManager : MonoBehaviour
{
    public  PlayerManager PlayerManager;
    public PlayerMovement PlayerMovement;
    public void AwardFromChest(int ChestID)
    {
        switch (ChestID)
        {
        case 0:
            PlayerManager.AddGold(100);
        break;
        }
    }
}
