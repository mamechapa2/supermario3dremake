using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedoTedFollowPlayer : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float timeBeforeExplode = 10;

    public GameObject explosion;
    public AudioSource explosionAudio;

    private bool explota = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(explode());
    }

    // Update is called once per frame
    void Update()
    {
        if (!explota)
        {
            Vector3 target = player.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            transform.LookAt(target); 
        }
    }

    private IEnumerator explode()
    {  
        yield return new WaitForSeconds(timeBeforeExplode);
        explota = true;
        Instantiate(explosion, transform.position, Quaternion.identity).SetActive(true);
        explosionAudio.Play();
        Destroy(this.gameObject);
    }
}
