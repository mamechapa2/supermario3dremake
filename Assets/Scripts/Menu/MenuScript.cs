using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject canvasMenu;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(GameObject.Find("StarsMonitor"));
        Destroy(GameObject.Find("CoinMonitor"));
        Destroy(GameObject.Find("LifeMonitor"));
        if(GameObject.Find("Canvas") != canvasMenu)
        {
            Destroy(GameObject.Find("Canvas"));
        }
    }
}
