using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockPipe : MonoBehaviour
{
    public AudioSource starAudio;
    public GameObject star;

    public AudioSource unlockAudio;
    public GameObject pipe;

    private void OnTriggerEnter(Collider other)
    {
        GlobalStars.starsCount += 1;
        this.GetComponent<MeshCollider>().isTrigger = false;
        this.GetComponent<MeshCollider>().enabled = false;
        pipe.SetActive(true);
        
        this.transform.position = new Vector3(0, -1000, 0);
        starAudio.Play();
        unlockAudio.Play();        
    }
}
