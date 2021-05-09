using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveHorizontal : MonoBehaviour
{
    public float resetPointRight;
    public float resetPointLeft;
    public float currentPoint;
    public int direction; //1 RIGHT, 0 LEFT
    // Start is called before the first frame update
    void Start()
    {
        direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        currentPoint = transform.position.x;

        if (direction == 1)
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }

        if (currentPoint > resetPointRight && direction == 1)
        {
            direction = 0;
        }

        if (currentPoint < resetPointLeft && direction == 0)
        {
            direction = 1;
        }


    }
}

