using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (GameObject.Find("Canvas") != this.gameObject)
        {
            print("canvas destruido");
            Destroy(GameObject.Find("Canvas"));
        }
    }
}
