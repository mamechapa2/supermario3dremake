using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    public AudioSource coinAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        transform.position = new Vector3(0, -1000, 0);
        coinAudio.Play();
        GlobalCoins.coinCount += 1;
        print("aaaaaaaa");
    }
}
