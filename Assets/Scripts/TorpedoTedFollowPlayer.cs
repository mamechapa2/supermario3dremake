using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedoTedFollowPlayer : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float timeBeforeExplode = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = player.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        transform.LookAt(target);
        StartCoroutine(explode());
    }

    private IEnumerator explode()
    {
        yield return new WaitForSeconds(timeBeforeExplode);
        Destroy(this.gameObject);
    }
}
