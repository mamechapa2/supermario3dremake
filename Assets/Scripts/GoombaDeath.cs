using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaDeath : MonoBehaviour
{
    public GameObject goomba;
    public BoxCollider death;
    public GoombaPatrol gp;

    public AudioSource deathFx;
    public Animator animator;

    private IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.tag.Equals("Player"))
        {
            animator.enabled = false;
            deathFx.Play();
            gp.enabled = false;
            GetComponent<BoxCollider>().enabled = false;
            death.enabled = false;

            goomba.transform.localScale -= new Vector3(0, (float)0.3, 0);

            yield return new WaitForSeconds(1);

            goomba.transform.position = new Vector3(0, -1000, 0);
        }
    }
}
