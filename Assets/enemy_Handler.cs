using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy_Handler : MonoBehaviour
{

    public NavMeshAgent Snakes;

    public GameObject player;

    public float Enemy_Laif = 90;

    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Snakes.destination = player.transform.position;
        }

    }

 
    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.CompareTag("Bullet"))
        {
            Enemy_Laif -= 30;

            if(Enemy_Laif <= 0 )
            {
          
                Destroy(this.gameObject);

            }
        }
    }
}
