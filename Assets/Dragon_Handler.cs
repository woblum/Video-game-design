using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon_Handler : MonoBehaviour
{
    public float Gragon_Laif = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Bullet"))
        {
            Gragon_Laif -= 20;

            if (Gragon_Laif <= 0)
            {

                Destroy(this.gameObject);

            }
        }
    }
}
