using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBlock : MonoBehaviour
{
    public GameObject block;
    public GameObject deadBlock;
    public Animator animationBlock;

    private IEnumerator OnTriggerEnter(Collider col)
    {
        block.SetActive(false);
        deadBlock.SetActive(true);
        yield return new WaitForSeconds(0.40F);
        animationBlock.enabled = false;
        Destroy(deadBlock);
    }
}
