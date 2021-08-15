using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PacmanDot : MonoBehaviour
{

    ScoreManager scoreManager;
    AudioSource playerSound;
    public AudioClip playerClip;
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        playerSound = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            playerSound.clip = playerClip;
            playerSound.Play();
            scoreManager.IncrementScore();
            Destroy(this.gameObject);
            
        }
           
    }
}
