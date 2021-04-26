using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeExit : MonoBehaviour
{
    public AudioSource pipeSound;
    public GameObject fadeScreen;
    public GameObject pipeEntry;
    public GameObject mainPlayer;

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
        pipeSound.Play();
        fadeScreen.SetActive(true);
        fadeScreen.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds((float)0.5);
        fadeScreen.GetComponent<Animator>().enabled = false;
        mainPlayer.transform.position = new Vector3(24, 0, (float)0.5);
        pipeEntry.GetComponent<Animator>().enabled = true;
        fadeScreen.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds((float)0.49);
        fadeScreen.GetComponent<Animator>().enabled = false;
        yield return new WaitForSeconds(1);
        pipeEntry.GetComponent<Animator>().enabled = false;
        fadeScreen.SetActive(false);
    }
}
