using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveHorizontal : MonoBehaviour
{
    public float resetPointRight;
    public float resetPointLeft;
    public float currentPoint;
    public int direction; //1 RIGHT, 0 LEFT

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
        currentPoint = transform.position.x;

        if (direction == 1)
        {
            transform.Translate(Vector3.right * 3 * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * 3 * Time.deltaTime);
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

    private void OnTriggerStay(Collider col)
    {
        if (col.tag.Equals("Player"))
        {
            //target = col.gameObject;
            //offset = target.transform.position - transform.position;
            
            //col.transform.position = transform.position;
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
        if(target != null)
        {
            //target.transform.position = transform.position + offset;
            //target.GetComponent<CharacterController>().Move(transform.position * Time.deltaTime);
        }
    }
}

