using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePiranhaAttack : MonoBehaviour
{
    public GameObject prefab;
    public Transform startPos;
    public float waitTimeBeforeShooting;
    public GameObject player;
    public float visionRadius;

    public Animator animator;

    private bool shootNow = true;
    // Start is called before the first frame update
    void Start()
    {
        animator.speed = 0;
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
        animator.speed = 0.5f;
        Instantiate(prefab, prefab.transform.position, Quaternion.identity).SetActive(true);
        yield return new WaitForSeconds(2);
        animator.speed = 0;
        
        yield return new WaitForSeconds(waitTimeBeforeShooting);
        shootNow = true;
    }


}
