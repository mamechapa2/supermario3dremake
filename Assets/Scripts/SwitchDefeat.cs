using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDefeat : MonoBehaviour
{
    public Transform switchObject;

    public void OnTriggerEnter(Collider other)
    {
        GetComponent<BoxCollider>().enabled = false;
        switchObject.position = new Vector3(switchObject.position.x, switchObject.position.y - 0.29f, switchObject.position.z);
        BossControl.setDie();
    }
}
