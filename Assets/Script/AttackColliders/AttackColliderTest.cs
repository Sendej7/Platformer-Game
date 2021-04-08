using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackColliderTest : MonoBehaviour
{
    public bool attacked;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy")&&attacked==true)
            {
                Destroy(other.gameObject);
                Debug.Log("Killed");
            }
    }
}
