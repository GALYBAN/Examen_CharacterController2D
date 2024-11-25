using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{

[SerializeField] private Text coinsUI;

void Update()
{
    int currentCoins = 0;
    coinsUI.text = currentCoins.ToString();
}

void OnTriggerEnter2D(Collider2D collider)
{
    if(collider.gameObject.CompareTag("Player"))
    {
        PlusCoin();
        Destroy(gameObject, 0.5f);
    }
}

void PlusCoin()
{
    int currentCoins = 0;
    currentCoins ++;
}

}
