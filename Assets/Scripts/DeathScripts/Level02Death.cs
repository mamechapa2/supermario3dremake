using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level02Death : MonoBehaviour
{
    public AudioSource deathSound;
    public GameObject player;
    public AudioSource levelSound;
    public AudioSource lostMushroom;

    private IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.tag.Equals("Player"))
        {
            if (!GlobalLives.bigMario)
            {
                player.GetComponent<ThirdPersonMovement>().enabled = false;
                player.GetComponent<CharacterController>().enabled = false;
                levelSound.Stop();
                print(this.name + " - " + col.name);
                GlobalLives.lives -= 1;
                deathSound.Play();
                player.transform.localScale -= new Vector3(0, (float)0.7, 0);
                yield return new WaitForSeconds(3);
                SceneManager.LoadScene(4);
            }
            else
            {
                lostMushroom.Play();
                GlobalLives.bigMario = false;
                player.transform.localScale -= new Vector3((float)0.3, (float)0.3, (float)0.3);
            }
        }
    }
}

