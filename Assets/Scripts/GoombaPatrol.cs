using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaPatrol : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;

    public Transform[] moveSpots;
    private int randomSpot;

    private Animator animator;
    private bool caminar = true;

    private GameObject player;
    public float runningSpeed;
    public float visionRadius;
    private bool perseguir = false;
    private float initialY;
    private bool parar = false;

    public AudioSource spotted;
    public bool spottedBefore = false;
    // Start is called before the first frame update
    void Start()
    {
        initialY = transform.position.y;
        animator = GetComponentInChildren<Animator>();
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (parar)
        {
            animator.speed = 0;
        }
        else
        {
            Vector3 target = moveSpots[randomSpot].position;
            float dist = Vector3.Distance(player.transform.position, transform.position);
            if (dist < visionRadius)
            {
                if (!spottedBefore)
                {
                    spotted.Play();
                    spottedBefore = true;
                }

                if (player.transform.position.y > this.transform.position.y)
                {

                }
                else
                {
                    target = player.transform.position;
                    perseguir = true;
                    caminar = false;
                }
            }
            else
            {
                spottedBefore = false;
                perseguir = false;
                caminar = true;
            }

            if (caminar)
            {
                animator.speed = 0.5f;
                transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
                transform.LookAt(moveSpots[randomSpot]);
            }
            else
            {
                if (perseguir)
                {
                    animator.speed = 1;
                    target.y = initialY;
                    transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime * 2);
                    transform.LookAt(target);
                }
            }

            if (Vector3.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
            {
                StartCoroutine(esperar());
            }
        }
    }

    IEnumerator esperar()
    {
        randomSpot = Random.Range(0, moveSpots.Length);
        caminar = false;
        animator.speed = 0;
        yield return new WaitForSeconds(startWaitTime);
        caminar = true;

    }

    private void OnTriggerEnter(Collider other)
    {
        print("El gooooooooooomba" + other.name);
        if (!other.tag.Equals("Player"))
        {
            perseguir = false;
            parar = true;
            StartCoroutine(reiniciar());
        }
    }

    private IEnumerator reiniciar()
    {
        yield return new WaitForSeconds(3);
        parar = false;
    }
}
