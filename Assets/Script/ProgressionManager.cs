using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressionManager : MonoBehaviour
{
    public List<bool> MileStones;
    public PlayerMovement PlayerMovement;
    public GenerateEnemy GenerateEnemy;

    public void UnlockNewThings(int ID)
    {
        switch (ID)
        {
        case 0:
            PlayerMovement.jumpForce=4;
            GenerateEnemy.GenerateEnemies(0,0);
            break;
        }
    }
}
