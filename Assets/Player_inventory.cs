using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_inventory : MonoBehaviour
{
    public string Food_1_tag = "Food 1";

    public string Food_2_tag = "Food 2";

    public float Food_1_Persent = 0;

    public float Food_2_Persent = 0;

    public Text Food_1_Text;
    public Text Food_2_Text;

    public AudioSource Get_Point_Sound;
    void Start()
    {
        Food_1_Text.text = "Food 1  = 0% ";
        Food_2_Text.text = "Food 2  = 0% ";
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
      
        
        if(other.CompareTag("Food 1"))
        {
            Food_1_Persent += 12.5f;
            Food_1_Text.text = "Food 1  = " + Food_1_Persent.ToString() + "% ";
            Get_Point_Sound.Play();
            Destroy(other.gameObject);

        }

        if (other.CompareTag("Food 2"))
        {
            Food_2_Persent += 12.5f;
            Food_2_Text.text = "Food 2  = " + Food_2_Persent.ToString() + "% ";
            Get_Point_Sound.Play();
            Destroy(other.gameObject);

        }

        if(Food_1_Persent == 100 )
        {
            if(Food_2_Persent == 100 )
            {
                SceneManager.LoadScene("Kab");
            }
        }
    }

    
}
