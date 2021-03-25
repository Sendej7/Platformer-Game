using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MileStones : MonoBehaviour
{
    public ProgressionManager ProgressionManager;
    public int ID;
    private void OnTriggerStay2D(Collider2D other) 
    {
        if(ProgressionManager.MileStones[ID]==false&&Input.GetKey("e"))
        {
            ProgressionManager.MileStones[ID]=true;
            ProgressionManager.UnlockNewThings(ID);
            Destroy(gameObject);
        }
    }

}
