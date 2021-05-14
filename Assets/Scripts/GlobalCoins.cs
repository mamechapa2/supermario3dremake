using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCoins : MonoBehaviour
{
    public GameObject coinDisplay;
    public static int  coinCount = 0;
    public int internalCoin;
    public AudioSource lifeSound;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (GameObject.Find("CoinMonitor").gameObject != this.gameObject)
        {
            Destroy(GameObject.Find("CoinMonitor"));
        }

    }

    // Update is called once per frame
    void Update()
    {
        internalCoin = coinCount;
        coinDisplay.GetComponent<Text>().text = "" + coinCount;

        if(coinCount >= 100)
        {
            coinCount = 0;
            internalCoin = 0;
            lifeSound.Play();
            GlobalLives.lives += 1;
        }

        if (Input.GetKeyDown("p"))
        {
            coinCount = 999;
        }
    }
}
