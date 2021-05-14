using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level01End : MonoBehaviour
{
    public GameObject fadeScreen;
    public GameObject player;

    private IEnumerator OnTriggerEnter(Collider col)
    {
        fadeScreen.SetActive(true);
        fadeScreen.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds((float)0.5);
        fadeScreen.GetComponent<Animator>().enabled = false;
        SceneManager.LoadScene(4);
    }
}
