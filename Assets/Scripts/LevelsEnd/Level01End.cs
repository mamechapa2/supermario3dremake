using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level01End : MonoBehaviour
{
    public GameObject fadeScreen;
    public GameObject player;
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
        fadeScreen.SetActive(true);
        fadeScreen.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds((float)0.5);
        fadeScreen.GetComponent<Animator>().enabled = false;
        SceneManager.LoadScene(4); //CAMBIAAAAAAAAAAAAAAAAAAAAAR
    }
}
