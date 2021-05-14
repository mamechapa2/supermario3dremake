using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasControl : MonoBehaviour
{

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (GameObject.Find("Canvas") != this.gameObject)
        {
            Destroy(GameObject.Find("Canvas"));
        }
    }
}
