using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GlobalLives : MonoBehaviour
{
    public int startingLives;
    public static int lives = 3;
    public int internalLives;
    public GameObject lifeTextBox;
    public static bool bigMario = false;

    private bool startedBefore = false;
    // Start is called before the first frame update
    void Start()
    {
            //lives = startingLives;
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (GameObject.Find("LifeMonitor") != this.gameObject)
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
        SceneManager.LoadScene(3);
    } 
}
