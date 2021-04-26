using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaDeath : MonoBehaviour
{
    public GameObject goomba;
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
        GetComponent<BoxCollider>().enabled = false;
        goomba.GetComponent<GoombaMove>().enabled = false;
        goomba.transform.localScale -= new Vector3(0, 0, (float)0.3);
        //goomba.transform.localPosition -= new Vector3(0, (float)0.4, 0);
        yield return new WaitForSeconds(1);
        goomba.transform.position = new Vector3(0, -1000, 0);
    }
}
