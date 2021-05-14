using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossControl : MonoBehaviour
{
    public GameObject prefab;
    public Transform startPos;
    public float waitTimeBeforeShooting;
    private List<GameObject> fireballs;

    private bool shootNow = true;
    public static bool die = false;

    public Animator animator;

    //Para las explosiones
    public GameObject explosion;
    public float xmin;
    public float xmax;
    public float zmin;
    public float zmax;
    public float ymin;
    public float ymax;
    public AudioSource explosionAudio;
    public AudioSource levelMusic;
    public AudioSource endMusic;
    
    // Start is called before the first frame update
    void Start()
    {
        fireballs = new List<GameObject>();
        animator.SetFloat("speed", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (die)
        {
            foreach (GameObject aux in fireballs)
            {
                print("alamierda");
                Destroy(aux);
            }
            animator.SetFloat("speed", 1);
            levelMusic.Stop();
            endMusic.Play();
            StartCoroutine(dissapear());
            die = false;
            shootNow = false;
            StopCoroutine(shoot());
        }
        if (shootNow && !die)
        {
            StartCoroutine(shoot());
        }
    }

    public IEnumerator shoot()
    {
        shootNow = false;
        GameObject aux = Instantiate(prefab, startPos.position, Quaternion.identity);
        aux.SetActive(true);
        fireballs.Add(aux);
        yield return new WaitForSeconds(waitTimeBeforeShooting);
        shootNow = true;
    }

    public static void setDie()
    {
        die = true;
    }

    public IEnumerator dissapear()
    {
        for (int i = 0; i < 20; i++)
        {
            var position = new Vector3(Random.Range(xmin, xmax), Random.Range(ymin, ymax), Random.Range(zmin, zmax));
            Instantiate(explosion, position, Quaternion.identity).SetActive(true);
            explosionAudio.Play();
            yield return new WaitForSeconds(0.5f);
        }

        SceneManager.LoadScene(0);
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
    }


}
