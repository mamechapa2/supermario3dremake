using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCollect : MonoBehaviour
{
    public AudioSource starAudio;
    public GameObject star;
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
        this.GetComponent<MeshCollider>().enabled = true;
        star.transform.position = new Vector3(0, -1000, 0);
        starAudio.Play();
        GlobalStars.starsCount += 1;
        print("1 star");
        
    }
}
