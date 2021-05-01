using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level01Death : MonoBehaviour
{
    public AudioSource deathSound;
    public GameObject player;
    public AudioSource levelSound;
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
        levelSound.Stop();
        print(this.name + " - " + col.name);
        GlobalLives.lives -= 1;
        deathSound.Play();
        player.transform.localScale -= new Vector3(0, (float)0.7, 0);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
}
