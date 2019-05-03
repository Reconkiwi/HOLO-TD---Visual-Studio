using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using UnityEngine.AI;
using HoloToolkit.Unity.InputModule;

public class NewBehaviourScript : MonoBehaviour
{




    public GameObject objCamera;
    private Vector3 SpawnPosition;
    private int DistanceToCamera = 1;
    public Transform tower;
    public Transform cannon;

    [System.Serializable]
    public class Wave
    {
        public string name;
        public Transform enemy;
        public int count;
        public float rate;
    }

    public Wave[] waves;
    private int nextWave = 0;


    private float searchCountdown = 1f;
    

    // Start is called before the first frame update
    void Start()
    {

        objCamera = (GameObject)GameObject.FindWithTag("MainCamera");
        Debug.Log("attacker not active");
 


    }

 




    public void WaveCompleted()
    {

        GameObject.Find("BOARD").GetComponent<HandDraggable>().enabled = false;
            StartCoroutine(SpawnAgent(waves[nextWave]));
            nextWave++;


      

        if (nextWave + 1 > waves.Length - 1)
        {
            nextWave = 0;
        }

    }

    void Update()
    {


        if (!EnemyIsAlive())
        {

           


        } else
        {
            
           
            
        }

    }

    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            searchCountdown = 1f;
            if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                Debug.Log("no enemies!!!!");
                return false;
            }

        }
       
        return true;
    }
    
    IEnumerator SpawnAgent(Wave _wave)
    {
        for (int i = 0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(1f / _wave.rate);
        }

        yield break;
    }

    void SpawnEnemy (Transform _enemy)
    {
        Instantiate(_enemy, transform.position, transform.rotation);
        Debug.Log("spawning enemy: +" + _enemy.name);
    }

   public void BuyTower()
    {
        if (PlayerStats.Money >= Tower1.towerWorth)
        {
            PlayerStats.Money -= Tower1.towerWorth;
            SpawnPosition = objCamera.transform.forward * DistanceToCamera + objCamera.transform.position;
            Instantiate(tower, SpawnPosition, Quaternion.identity);
        } else
        {
            Debug.Log("no money!");
        }
    }

    public void BuyCannon()
    {
        if (PlayerStats.Money >= Tower1.towerWorth)
        {
            PlayerStats.Money -= Tower1.towerWorth;
            SpawnPosition = objCamera.transform.forward * DistanceToCamera + objCamera.transform.position;
            Instantiate(cannon, SpawnPosition, Quaternion.identity);
        }
        else
        {
            Debug.Log("no money!");
        }
    }
}
