using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionBlock : MonoBehaviour
{
    public GameObject questionBlock;
    public GameObject deadBlock;
    public GameObject mushroom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator OnTriggerEnter(Collider col)
    {
        print("aaaaaaaaaaaaaaaaaaaaaaaaaaa");
        questionBlock.SetActive(false);
        deadBlock.SetActive(true);
        yield return new WaitForSeconds((float)0.2);
        mushroom.SetActive(true);
    }
}
