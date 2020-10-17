using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class levelController : MonoBehaviour
{
    
    public GameObject currentCheckpoint;
    private playerController player;

    public GameObject particulaMuerte;
    public GameObject particulaReinicio;
    public float respawnDelay;

    //puntos de penalizacion por muerte
    public int puntosDePenalizacion;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RespawnPlayer(){        
        UnityEngine.Debug.Log("you are dead!!!!");
        StartCoroutine("RespawnPlayerCorutina");
        player.transform.position = currentCheckpoint.transform.position;
    }

    public IEnumerator RespawnPlayerCorutina(){
        Instantiate(particulaMuerte, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        puntajeController.AgregarPuntos(-puntosDePenalizacion);
        yield return new WaitForSeconds(respawnDelay);
        player.transform.position = currentCheckpoint.transform.position;
        Instantiate(particulaReinicio, player.transform.position, player.transform.rotation);
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;
    }
}
