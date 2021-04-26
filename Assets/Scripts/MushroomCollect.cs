using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomCollect : MonoBehaviour
{
    public AudioSource growSound;
    public GameObject player;
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
        print(col.name);
        if(col.gameObject.tag == "Player")
        {
            this.transform.position = new Vector3(0, -1000, 0);
            growSound.Play();
            player.transform.localScale += new Vector3((float)0.3, (float)0.3, (float)0.3);
        }
    }
}
