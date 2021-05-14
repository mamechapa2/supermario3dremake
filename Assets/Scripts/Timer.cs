using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int startTime = 3;
    public GameObject timeDisplay;
    public AudioSource deathSound;
    public GameObject player;
    bool calculating = false;
    bool death = false;

    // Update is called once per frame
    void Update()
    {
        if (!death)
        {
            timeDisplay.GetComponent<Text>().text = "" + startTime;
        }

        if (!calculating)
        {
            StartCoroutine(calculateTime());
        }

        if(startTime == 0)
        {
            StartCoroutine(TimeUp());
        }
    }

    IEnumerator calculateTime()
    {
        calculating = true;
        startTime--;
        yield return new WaitForSeconds(1);
        calculating = false;
    }

    IEnumerator TimeUp()
    {
        startTime--;
        death = true;
        timeDisplay.GetComponent<Text>().text = "0";
        GlobalLives.lives--;
        deathSound.Play();
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
