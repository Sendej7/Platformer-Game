using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectWhenOutsideCamera : MonoBehaviour
{
    void OnBecameInvisible() 
    {
        enabled = false;
    }
    void OnBecameVisible() 
    {
        enabled = true;
    }
}
