using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Helf_Controler : MonoBehaviour
{
    public float player_helf = 100;
    public Text Player_Laif_Text;

   
    public AudioSource Get_Het_Sound;


    void Start()
    {
        Player_Laif_Text.text = player_helf.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnCollisionEnter(Collision other)
    {
  

        if (other.collider.CompareTag("Enemy"))
        {
            player_helf -= 1f;
            
            Get_Het_Sound.Play();

            Player_Laif_Text.text = player_helf.ToString("N0");

            if (player_helf <= 0)
            {

                Destroy(this.gameObject);

                SceneManager.LoadScene(0);

            }
        }
    }


}
