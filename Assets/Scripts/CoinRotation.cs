using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public float speed = 0.5F;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed, 0, Space.World);
    }
}
