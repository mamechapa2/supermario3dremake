using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeEntryExit : MonoBehaviour
{
    private bool estaEncima = false;
    public Animator animacion;
    public GameObject player;
    public GameObject exit;
    public GameObject fadeScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (estaEncima)
            {
                print("bajando");
                //animacion.enabled = true;
                StartCoroutine(usePipe());
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        print("encima");
        estaEncima = true;
    }

    private void OnTriggerExit(Collider other)
    {
        print("se baja");
        estaEncima = false;
    }

    private IEnumerator usePipe()
    {
        estaEncima = false; //Para no repetir

        //La activa hasta que baja
        animacion.enabled = true;
        yield return new WaitForSeconds(0.9f);
        
        //Se queda abajo y pantalla en negro
        animacion.enabled = false;
        fadeScreen.SetActive(true);
        fadeScreen.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.9f);
        fadeScreen.GetComponent<Animator>().enabled = false;
        //Desactiva scripts y character controller 
        print("jodeeeeeeeeeeeeeeeeer");
        player.GetComponent<ThirdPersonMovement>().enabled = false;
        player.GetComponent<CharacterController>().enabled = false;
        
        //Teletransporta al jugador
        player.transform.position = exit.transform.position;

        //Activa scripts y character controller 
        player.GetComponent<ThirdPersonMovement>().enabled = true;
        player.GetComponent<CharacterController>().enabled = true;

        //Se vuelve arriba y pantalla blanquita
        animacion.enabled = true;
        fadeScreen.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.1f);
        animacion.enabled = false;
        yield return new WaitForSeconds(0.9f);
        fadeScreen.SetActive(false);
        fadeScreen.GetComponent<Animator>().enabled = false;

    }
}
