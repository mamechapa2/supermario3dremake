using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float resetPointTop;
    public float resetPointBot;
    public float currentPoint;
    public int direction; //1 UP, 0 DOWN
    // Start is called before the first frame update
    void Start()
    {
        direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        currentPoint = transform.position.y;

        if(direction == 1)
        {
            transform.Translate(Vector3.up * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * Time.deltaTime);
        }
        
        if(currentPoint > resetPointTop && direction == 1)
        {
            direction = 0;
        }
        
        if(currentPoint < resetPointBot && direction == 0)
        {
            direction = 1;
        }

        
    }
}
