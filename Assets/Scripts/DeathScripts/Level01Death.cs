using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level01Death : MonoBehaviour
{
    public AudioSource deathSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator OnTriggerEnter(Collider col)
    {
        deathSound.Play();
        yield return new WaitForSeconds(3);
    }
}
