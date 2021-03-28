using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAI : MonoBehaviour
{

    GameObject Player;
    Transform target;//set target from inspector instead of looking in Update
    GameObject PlayerManagerGO;
    public float speed;
    public float distance;
    public float agroRange;
    public GameObject Explosion;
    PlayerManager PlayerManager;
    void Start()
    {
        Player = GameObject.FindWithTag ("Player"); 
        target = Player.transform; 
        PlayerManagerGO = GameObject.Find("PlayerManager"); 
        PlayerManager= PlayerManagerGO.GetComponent<PlayerManager>();
    }
 
     void Update()
     {
        if (Vector3.Distance(transform.position, target.position) < agroRange) //Agro range
        {  
            transform.LookAt(target.position);
            transform.Rotate(new Vector3(0, -90, 0), Space.Self);//correcting the original rotation
        }

        if (Vector3.Distance(transform.position, target.position) < agroRange) //Agro range
        {   
            if (Vector3.Distance(transform.position, target.position) > distance)
            {
                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(Explosion, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            Debug.Log("exploded");
            PlayerManager.LoseHP(1);
        }
        
    }
}
