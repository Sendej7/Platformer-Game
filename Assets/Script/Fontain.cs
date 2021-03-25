using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fontain : MonoBehaviour
{
    public GameObject Text;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Text.SetActive(true);
        }
        
    }
    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Text.SetActive(false);
        }
    }
}
