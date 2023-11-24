using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int coins = 0;
    public Text coinCounter;
    public AudioSource collectSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            coins++;
            coinCounter.text = "Coins: " + coins;
        }
    }
}
