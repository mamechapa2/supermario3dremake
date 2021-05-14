using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomCollect : MonoBehaviour
{
    public AudioSource growSound;
    public GameObject player;

    public AudioSource life;

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            if (!GlobalLives.bigMario)
            {
                this.transform.position = new Vector3(0, -1000, 0);
                growSound.Play();
                player.transform.localScale += new Vector3((float)0.3, (float)0.3, (float)0.3);
                GlobalLives.bigMario = true;
            }
            else
            {
                this.transform.position = new Vector3(0, -1000, 0);
                life.Play();
                GlobalLives.lives += 1;
            }
        }
    }
}
