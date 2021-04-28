using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GlobalLives : MonoBehaviour
{
    public static int lives = 3;
    public int internalLives;
    public GameObject lifeTextBox;

    // Start is called before the first frame update
    void Start()
    {
        
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