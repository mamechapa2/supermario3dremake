using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaMove : MonoBehaviour
{
    public float leftPoint = 11;
    public float rightPoint = 23;
    public int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(direction == 1)
        {
            transform.Translate(Vector3.right * 2 * Time.deltaTime, Space.World);
            direction = 1;
        }

        if(this.transform.position.x > rightPoint)
        {
            direction = 0;
        }

        if (direction == 0)
        {
            transform.Translate(Vector3.right * -2 * Time.deltaTime, Space.World);
            direction = 0;
        }

        if (this.transform.position.x < leftPoint)
        {
            direction = 1;
        }


    }
}
