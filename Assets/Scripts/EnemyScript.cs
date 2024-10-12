using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject player;
    public GameObject zombie;
    public float speed, elapsedTime = 0.0f, spawnSeconds;
    Renderer zombieRenderer;
    Player playerScript;

  
    void Start()
    {
       

    }
    // Update is called once per frame
    void Update()
    {

        zombie.transform.position = Vector3.MoveTowards(zombie.transform.position, player.transform.position, speed);

        //elapsedTime += Time.deltaTime;

        //if (elapsedTime > spawnSeconds)
        //{
        //    elapsedTime = 0;

        //    Vector3 spawnPosition = new Vector3(10,0,-10);
        //    Instantiate(zombie.transform, spawnPosition, Quaternion.identity);
        //}



    }

}
