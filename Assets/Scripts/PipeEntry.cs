using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeEntry : MonoBehaviour
{

    [SerializeField]
    public Animator pipeCollider;
    public GameObject MainPlayer;
    public Animator FadeScreenAnimator;
    public GameObject FadeScreenObject;
    public AudioSource PipeSound;
    public GameObject exit;

    public int StoodOn;
    public int qwerty;
    

    void OnTriggerEnter(Collider col)
    {
        StoodOn = 1;
        MainPlayer = col.gameObject;
        print(StoodOn);
    }
    void OnTriggerExit(Collider col)
    {
        StoodOn = 0;
        print(StoodOn);
    }
    // Use this for initialization
    void Start()
    {
        pipeCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (StoodOn == 1)
            {
                transform.position = new Vector3(0, -1000, 0);
                StartCoroutine(WaitingForPipe());
                //pipeCollider.enabled = true;               
                qwerty = 1;

            }
        }
    }

    IEnumerator WaitingForPipe()
    {
        PipeSound.Play();

        FadeScreenObject.SetActive(true);

        pipeCollider.enabled = true;
        yield return new WaitForSeconds((float)0.5);
        FadeScreenAnimator.enabled = true;
        yield return new WaitForSeconds((float)0.5);
        FadeScreenAnimator.enabled = false;
        pipeCollider.enabled = false;
        MainPlayer.transform.position = exit.transform.position;
        FadeScreenAnimator.enabled = true;
        yield return new WaitForSeconds(1);
        FadeScreenAnimator.enabled = false;
        FadeScreenObject.SetActive(false);
    }
}
