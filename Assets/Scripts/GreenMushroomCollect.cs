using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenMushroomCollect : MonoBehaviour
{
    public AudioSource lifeSound;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            this.transform.position = new Vector3(0, -1000, 0);
            lifeSound.Play();
            GlobalLives.lives++;
        }
    }

}
