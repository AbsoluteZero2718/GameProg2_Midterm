using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    GameObject enemy;
    public GameObject knifePrefab;
    public Transform knifeSpawnPoint;
    public Transform zombie;
    public Transform sight;
    public float nextFire, fireRate;

    public float playerRange, enemyDistance, knifeDelay;
    float enemyPositionx, enemyPositionz;

    public Color[] Colors = { Color.red, Color.green, Color.blue };
    public Renderer rend;

    public int index = 0, enemyCount = 0;



    void Start()
    {
        rend.material.color = Colors[index];

        zombie = GameObject.FindGameObjectWithTag("RedZombie").transform;
       
    }


    // Update is called once per frame
    void Update()
    {
            enemyDistance = Vector3.Distance(zombie.position, transform.position);

            if (enemyDistance <= playerRange)
            {

                sight.LookAt(zombie);

                if (Time.time >= nextFire)
                {
                nextFire = Time.time + 1f / fireRate;
                   Shoot();
                }
            }
       
    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (index < Colors.Length - 1)
            {
                index++;
            }
            else
            {
                index = 0;
            }
            rend.material.color = Colors[index];
        }
    }

    void Shoot()
    {
       GameObject clone =  Instantiate(knifePrefab, knifeSpawnPoint.position, transform.rotation);
       clone.GetComponent<Rigidbody>().AddForce(transform.forward * 1500);
        Destroy(clone, 10);

    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, playerRange);
    }


}
