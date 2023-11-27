using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    private AudioSource finishSound;
    private bool levelCompleted = false; // zmienna odpowiadaj�ca za to, aby d�wi�k nie w��cza� si� kilka razy podczas przechodzenia przez collider

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
            Invoke("CompleteLevel", 2f); // op�nienie w wykonaniu funkcji CompleteLevel
        }
    }

    void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // zmiana sceny na t� o nast�pnym indexie
    }
}
