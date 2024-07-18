using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{

    public int NumOfCoinsCollected { get; private set; }

    public UnityEvent<PlayerInventory> OnCoinCollected;

    public void CoinsCollected()
    {
        NumOfCoinsCollected++;
        OnCoinCollected.Invoke(this);
    }

}
