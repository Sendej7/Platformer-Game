using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{
    public List<GameObject> EnemyType;
    public List<Transform> SpawnEnemies;
    public List<int> NumberOfEnemies;

    void Start() 
    {
        GenerateEnemies(0,0);
    }
    public void GenerateEnemies(int StageNumber, int WhateEnemyDoYouWant)
    {
        int x= StageNumber;
        int d= WhateEnemyDoYouWant;
        for(int i=0;i<NumberOfEnemies[x];i++)
        {
            Instantiate(EnemyType[d], new Vector3(Random.Range(SpawnEnemies[x].position.x-3,SpawnEnemies[x].position.x+3), Random.Range(-SpawnEnemies[x].position.y-1.5f,SpawnEnemies[x].position.y+1.5f), -0.5273438f), Quaternion.identity);
        }
    }
}
