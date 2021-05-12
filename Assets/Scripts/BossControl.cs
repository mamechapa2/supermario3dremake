using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossControl : MonoBehaviour
{
    public GameObject prefab;
    public Transform startPos;
    public float waitTimeBeforeShooting;

    private bool shootNow = true;
    public static bool die = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (die)
        {
            //CAMBIAR ANIMACIOn
            StartCoroutine(dissapear());
            //PONERLE MUSIQUILLA
            //TP AL PJ A LA SALA CON EL TOAD
        }
        if (shootNow && !die)
        {
            StartCoroutine(shoot());
        }
    }

    public IEnumerator shoot()
    {
        shootNow = false;
        Instantiate(prefab, startPos.position, Quaternion.identity).SetActive(true);
        yield return new WaitForSeconds(waitTimeBeforeShooting);
        shootNow = true;
    }

    public static void setDie()
    {
        die = true;
        print("cambiado");
    }

    public IEnumerator dissapear()
    {
        yield return new WaitForSeconds(10);
        Destroy(this.gameObject);
    }


}
