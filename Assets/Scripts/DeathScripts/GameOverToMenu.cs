using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(restart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator restart()
    {
        yield return new WaitForSeconds(5);
        GlobalLives.lives += 3;
        SceneManager.LoadScene(0);
    }
}
