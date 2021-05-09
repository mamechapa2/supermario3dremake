using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCannonLaunchTorpedo : MonoBehaviour
{
    public GameObject prefab;
    public Transform startPos;
    public float waitTimeBeforeShooting;
    public GameObject player;
    public float visionRadius;

    private bool shootNow = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distToPlayer = Vector3.Distance(player.transform.position, transform.position);
        if (shootNow && distToPlayer < visionRadius)
        {
            StartCoroutine(shoot());
        }
    }

    public IEnumerator shoot()
    {
        shootNow = false;
        Instantiate(prefab, prefab.transform.position, Quaternion.identity).SetActive(true);
        yield return new WaitForSeconds(waitTimeBeforeShooting);
        shootNow = true;
    }
}
