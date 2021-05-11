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
    

    void OnTriggerEnter(Collider col)
    {
        StoodOn = 1;
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
                StartCoroutine(WaitingForPipe());
                //MainPlayer.GetComponent<ThirdPersonMovement>().enabled = false;
                //print("Exit " + exit.transform.position.ToString());
                //MainPlayer.transform.position = exit.transform.position;
                //print("Player" + MainPlayer.transform.position.ToString());
                //MainPlayer.GetComponent<ThirdPersonMovement>().enabled = true;
                ////Debug.Log("Player");
                //print("Play");
            }
        }
    }

    private IEnumerator WaitingForPipe()
    {
        MainPlayer.GetComponent<ThirdPersonMovement>().enabled = false;

        PipeSound.Play();

        FadeScreenObject.SetActive(true);
        FadeScreenAnimator.enabled = true;
        pipeCollider.enabled = true;
        yield return new WaitForSeconds((float)0.5);

        
        MainPlayer.transform.position = exit.transform.position;

        //yield return new WaitForSeconds((float)1.5);

        //FadeScreenAnimator.enabled = false;
        //pipeCollider.enabled = false;
        //FadeScreenAnimator.enabled = true;

        //yield return new WaitForSeconds(1);
        //FadeScreenAnimator.enabled = false;
        //FadeScreenObject.SetActive(false);

        //print("wtf");
        MainPlayer.GetComponent<ThirdPersonMovement>().enabled = true;

    }
}
