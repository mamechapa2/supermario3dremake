using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockPipe : MonoBehaviour
{
    public AudioSource starAudio;
    public GameObject star;

    public AudioSource unlockAudio;
    public GameObject pipe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GlobalStars.starsCount += 1;
        print("xDDDDDDDDDDDDDDDDDD");
        this.GetComponent<MeshCollider>().isTrigger = false;
        this.GetComponent<MeshCollider>().enabled = false;
        pipe.SetActive(true);
        
        this.transform.position = new Vector3(0, -1000, 0);
        starAudio.Play();
        unlockAudio.Play();
        
        print("1 star");

        
    }
}
