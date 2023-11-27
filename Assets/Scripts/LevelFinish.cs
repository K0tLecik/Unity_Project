using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    private AudioSource finishSound;
    private bool levelCompleted = false; // zmienna odpowiadaj¹ca za to, aby dŸwiêk nie w³¹cza³ siê kilka razy podczas przechodzenia przez collider

    void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && levelCompleted == false)
        {
            finishSound.Play();
            levelCompleted = true;
            Invoke("CompleteLevel", 2f); // opóŸnienie w wykonaniu funkcji CompleteLevel
        }
    }

    void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // zmiana sceny na tê o nastêpnym indexie
    }
}
