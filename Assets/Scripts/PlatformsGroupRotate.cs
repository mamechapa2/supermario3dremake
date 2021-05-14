using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformsGroupRotate : MonoBehaviour
{
    public GameObject platform1;
    public GameObject platform2;
    public GameObject platform3;
    public GameObject platform4;

    public float speed = 0.5F;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed, 0, 0, Space.World);
        platform1.transform.Rotate(-speed, 0, 0, Space.World);
        platform2.transform.Rotate(-speed, 0, 0, Space.World);
        platform3.transform.Rotate(-speed, 0, 0, Space.World);
        platform4.transform.Rotate(-speed, 0, 0, Space.World);
    }
}
