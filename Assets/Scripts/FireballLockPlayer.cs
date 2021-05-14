using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballLockPlayer : MonoBehaviour
{
    public Transform player;
    public float destroyTime = 20;
    public float speed;

    private Vector3 target;
    private bool destroy = false;
    // Start is called before the first frame update
    void Start()
    {
        target = player.position;
        StartCoroutine(wait());
    }

    // Update is called once per frame
    void Update()
    {
        if (!destroy)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            if(transform.position == target)
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private IEnumerator wait()
    {
        
        yield return new WaitForSeconds(destroyTime);
        destroy = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (!other.tag.Equals("Player"))
        {
            Destroy(this.gameObject);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.tag.Equals("Player")){
            Destroy(this.gameObject);
        }
    }
}
