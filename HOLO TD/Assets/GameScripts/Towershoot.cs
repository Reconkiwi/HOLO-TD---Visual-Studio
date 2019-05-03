using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towershoot : MonoBehaviour
{
    public float DistanceFromCastle, CoolDown;
    public GameObject enemy;
    public GameObject Bullet;
    public int protectionRadius, bulletSpeed;
    private const int SPAWN_DISTANCE = 5;

    // Use this for initialization
    void Start()
    {
        protectionRadius = 20;
        bulletSpeed = 35;
        CoolDown = 5;

    }

    // Update is called once per frame
    void Update()
    {

        enemy = GameObject.FindGameObjectWithTag("Enemy");

        if (enemy != null)
        {
            DistanceFromCastle = Vector3.Distance(GameObject.FindGameObjectWithTag("Enemy").transform.position, GameObject.FindGameObjectWithTag("Defence").transform.position);
            //print (DistanceFromCastle);
            if (DistanceFromCastle <= protectionRadius)
            {
                attackEnemy();
            }

        }
    }
    void attackEnemy()
    {
        transform.LookAt(enemy.transform);
        CoolDown -= Time.deltaTime;
        if (CoolDown <= 0)
        {

            Debug.DrawLine(transform.position, enemy.transform.position, Color.red);
            Instantiate(Bullet, transform.position + SPAWN_DISTANCE * transform.forward, transform.rotation);

            print("attack Enemy");
            CoolDown = 5;
        }
    }
}

