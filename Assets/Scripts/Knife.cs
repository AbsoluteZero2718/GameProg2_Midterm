using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    Player player;
    Renderer knifeRenderer;

    public float knifeSpeed;

    void Start()
    {
        player = FindAnyObjectByType<Player>();

        knifeRenderer = GetComponent<Renderer>();
        knifeRenderer.material.color = player.Colors[player.index];


    }

    void Update()
    {
        transform.Translate(Vector3.forward * knifeSpeed * Time.deltaTime);

       
    }
  


    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("RedZombie"))
        {
            Destroy(other.gameObject);
            player.enemyCount++;
        
        }
      
    }
}
