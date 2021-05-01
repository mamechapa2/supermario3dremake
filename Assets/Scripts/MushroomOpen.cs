using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomOpen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("hola");
        StartCoroutine(CloseAnim());
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    IEnumerator CloseAnim()
    {
        yield return new WaitForSeconds(1.59F);
        GetComponent<Animator>().enabled = false;
    }
}
