using UnityEngine;
using UnityEngine.UI;

public class GlobalStars : MonoBehaviour
{
    public GameObject starsDisplay;
    public static int  starsCount = 0;
    public int internalStar;
    public int maxNumStars = 3;
    public GameObject end = null;
    private bool activeBefore = false;

    private void Awake()
    {
        starsCount = 0;
        DontDestroyOnLoad(gameObject);
        if (GameObject.Find("StarsMonitor") != this.gameObject)
        {
            Destroy(GameObject.Find("StarsMonitor"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        internalStar = starsCount;
        starsDisplay.GetComponent<Text>().text = "" + starsCount;

        if(starsCount >= maxNumStars && !activeBefore && end != null)
        {
            activeBefore = true;
            end.SetActive(true);
        }

        if (Input.GetKeyDown("p"))
        {
            starsCount = 999;
        }
    }
}
