using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossControl : MonoBehaviour
{
    public GameObject prefab;
    public Transform startPos;
    public int cantidadObstaculos;
    public float waitTimeBeforeShooting;

    private bool shootNow = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (shootNow)
        {
            StartCoroutine(shoot());
        }
    }

    public IEnumerator shoot()
    {
        shootNow = false;
        Instantiate(prefab, startPos.position, Quaternion.identity);
        yield return new WaitForSeconds(waitTimeBeforeShooting);
        shootNow = true;
    }


}
