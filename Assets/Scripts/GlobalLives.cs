using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GlobalLives : MonoBehaviour
{
    public int startingLives = 3;
    public static int lives = 3;
    public int internalLives;
    public GameObject lifeTextBox;
    public static bool bigMario = false;

    private bool startedBefore = false;

    public static GlobalLives globalLives;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Awake()
    {
        //DontDestroyOnLoad(this.gameObject);

        //if (globalLives == null)
        //{
        //    print("awake 1 global lives");
        //    globalLives = this;
        //    DontDestroyOnLoad(gameObject);
        //}
        //else if (globalLives != this)
        //{
        //    print("awake 2 global lives");
        //    DontDestroyOnLoad(gameObject);
        //}

        //GameObject[] otros = GameObject.FindGameObjectsWithTag("GameControlLives");

        //foreach (GameObject objeto in otros)
        //{
        //    if(objeto != this.gameObject)
        //    {

        //    }
        //}

        DontDestroyOnLoad(gameObject);
        if (GameObject.Find("LifeMonitor").gameObject != this.gameObject)
        {

            Destroy(GameObject.Find("LifeMonitor"));
        }
        print("awake");
    }

    // Update is called once per frame
    void Update()
    {
        internalLives = lives;
        lifeTextBox.GetComponent<Text>().text = "" + internalLives;

        if(internalLives == 0)
        {
            StartCoroutine(gameOver());
        }
    }

    IEnumerator gameOver()
    {
        
        yield return new WaitForSeconds((float)2.9);
        lives = startingLives;
        SceneManager.LoadScene(3);
        
    } 
}
