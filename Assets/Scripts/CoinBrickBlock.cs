using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBrickBlock : MonoBehaviour
{
    public GameObject block;
    public GameObject deadBlock;
    public GameObject blockObject;
    public Animator animationBlock;
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
        blockObject.SetActive(true);
        block.SetActive(false);
        deadBlock.SetActive(true);
        yield return new WaitForSeconds(0.40F);
        //animationBlock.enabled = false;
        Destroy(deadBlock);

        print("Asdasdadada");

    }
}
