using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionBlock : MonoBehaviour
{
    public GameObject block;
    public GameObject deadBlock;
    public GameObject blockObject;
    public Animator animationBlock;

    private IEnumerator OnTriggerEnter(Collider col)
    {
        blockObject.SetActive(true);
        block.SetActive(false);
        deadBlock.SetActive(true);
        yield return new WaitForSeconds(0.10F);
        //animationBlock.enabled = false;        
    }
}
