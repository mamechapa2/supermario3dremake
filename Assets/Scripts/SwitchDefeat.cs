using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDefeat : MonoBehaviour
{
    public Transform switchObject;
    private bool activated = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        GetComponent<BoxCollider>().enabled = false;
        switchObject.position = new Vector3(switchObject.position.x, switchObject.position.y - 0.29f, switchObject.position.z);
        activated = true;
        print("tttttttttttttttt");
    }
}
