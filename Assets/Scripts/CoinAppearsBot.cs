using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAppearsBot : MonoBehaviour
{

    public float speed;
    public Transform target;
    public GameObject coins;

    private bool activate = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activate)
        {
            coins.transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        this.GetComponent<SphereCollider>().enabled = false;
        activate = true;
    }
}
