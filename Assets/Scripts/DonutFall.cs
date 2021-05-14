using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutFall : MonoBehaviour
{
    public GameObject donut;

    private bool fall = false;

    // Update is called once per frame
    void Update()
    {
        if (fall)
        {
            donut.transform.Translate(Vector3.forward * 2 * Time.deltaTime);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        fall = true;
    }
}
