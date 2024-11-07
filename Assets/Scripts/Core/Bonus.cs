using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{

public int value = 10;
AudioManager audiomanager;



private void Awake(){
    audiomanager=GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
}

    private ParallaxBackgroundManager parallaxManager; 
    private GameObject Player;

    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "BorderBottom")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player") // Vérifie si le joueur a touché un bonus
        {
            audiomanager.PlaySFX(audiomanager.finishSFX); 
            Destroy(this.gameObject);
        }
    }
}