using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_Shooting_Controler : MonoBehaviour
{
    public GameObject Shoot_Point;

    public GameObject Bullet_Prifab;

    public float Bullet_Speed;

    public float Bullet_laif_Time;

    public ParticleSystem mazel_Flash;

    public AudioSource Shoot_Sound;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bullet =  Instantiate(Bullet_Prifab, Shoot_Point.transform.position , Shoot_Point.transform.rotation);

            bullet.GetComponent<Rigidbody>().AddForce(Shoot_Point.transform.forward * Bullet_Speed, ForceMode.Impulse);
            
            mazel_Flash.Play();

            Shoot_Sound.Play();

            Destroy(bullet, Bullet_laif_Time);
        }
    }
}
