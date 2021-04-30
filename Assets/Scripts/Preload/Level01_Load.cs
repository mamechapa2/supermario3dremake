using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level01_Load : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
