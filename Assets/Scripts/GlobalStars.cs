using UnityEngine;
using UnityEngine.UI;

public class GlobalStars : MonoBehaviour
{
    public GameObject starsDisplay;
    public static int  starsCount = 0;
    public int internalStar;
    public int maxNumStars = 1;
    public GameObject end;
    private bool activeBefore = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalStar = starsCount;
        starsDisplay.GetComponent<Text>().text = "Stars: " + starsCount;

        if(starsCount == maxNumStars && !activeBefore)
        {
            activeBefore = true;
            print("final activo");
            end.SetActive(true);
        }
    }
}
