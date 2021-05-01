using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCoins : MonoBehaviour
{
    public GameObject coinDisplay;
    public static int  coinCount;
    public int internalCoin;
    public AudioSource lifeSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalCoin = coinCount;
        coinDisplay.GetComponent<Text>().text = "Coins: " + coinCount;

        if(coinCount == 100)
        {
            coinCount = 0;
            internalCoin = 0;
            lifeSound.Play();
            GlobalLives.lives += 1;
        }
    }
}
