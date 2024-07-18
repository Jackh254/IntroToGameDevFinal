using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource coinAudio;
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        coinAudio.Play();
        if(playerInventory != null)
        {
            playerInventory.CoinsCollected();
            gameObject.SetActive(false);
        }
    }
}
