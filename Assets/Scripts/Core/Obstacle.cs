using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Obstacle : MonoBehaviour
{
    
AudioManager audiomanager;



private void Awake(){
    audiomanager=GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
}

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
        else if (collision.tag == "Player")
        {
            audiomanager.PlaySFX(audiomanager.damageSFX);  
            
            Destroy(Player.gameObject);
        }
    }
}