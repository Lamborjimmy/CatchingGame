using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Collision : MonoBehaviour
{
    private int hearts = 3;
    public GameObject heartFull1;
    public GameObject heartFull2;
    public GameObject heartFull3;
    public GameObject heartEmpty1;
    public GameObject heartEmpty2;
    public GameObject heartEmpty3;
    public AudioSource blop;
    public AudioSource hit;
    public GameObject gameOver;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "JunkFood")
        {
            ScoreManager.instance.MinusScore();
            Destroy(collision.gameObject);

        }
        if (collision.collider.tag == "HealthyFood")
        {
            PlayBlop();
            ScoreManager.instance.AddScore();
            Destroy(collision.gameObject);
        }
        if(collision.collider.tag == "Object")
        {
            PlayHit();
            Destroy(collision.gameObject);
            hearts--;
            if(hearts == 2)
            {
                heartFull1.SetActive(false);
                heartEmpty1.SetActive(true);
            }
            if(hearts == 1)
            {
                heartFull2.SetActive(false);
                heartEmpty2.SetActive(true);
            }
            if(hearts == 0)
            {
                heartFull3.SetActive(false);
                heartEmpty3.SetActive(true);
                gameOver.SetActive(true);
                Time.timeScale = 0f;
            }
            
        }
    }
    private void PlayBlop()
    {
        blop.Play();
    }
    private void PlayHit()
    {
        hit.Play();
    }
}

