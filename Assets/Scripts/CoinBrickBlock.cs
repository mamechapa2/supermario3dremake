using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBrickBlock : MonoBehaviour
{
    public GameObject block;
    public GameObject deadBlock;
    public GameObject blockObject;
    public Animator animationBlock;

    private IEnumerator OnTriggerEnter(Collider col)
    {
        Destroy(deadBlock);

        blockObject.SetActive(true);
        block.SetActive(false);
        deadBlock.SetActive(true);
        
        yield return new WaitForSeconds(0.4F);
        
        animationBlock.enabled = false;
        
        Destroy(deadBlock);
    }
}
