using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomOpen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CloseAnim());
    }

    IEnumerator CloseAnim()
    {
        yield return new WaitForSeconds(1.59F);
        GetComponent<Animator>().enabled = false;
    }
}
