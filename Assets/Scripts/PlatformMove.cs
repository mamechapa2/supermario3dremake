using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float resetPointTop;
    public float resetPointBot;
    public float currentPoint;
    public int direction; //1 UP, 0 DOWN
    public float speed = 1;

    private GameObject target = null;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        direction = 1;
        target = null;
    }

    // Update is called once per frame
    void Update()
    {
        currentPoint = transform.position.y;

        if(direction == 1)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
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

    private void OnTriggerStay(Collider col)
    {
        if (col.tag.Equals("Player"))
        {
            target = col.gameObject;
            offset = target.transform.position - transform.position;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag.Equals("Player"))
        {
            target = null;
        }
    }

    private void LateUpdate()
    {
        if (target != null)
        {
            //target.transform.position = transform.position + offset;
        }
    }
}
