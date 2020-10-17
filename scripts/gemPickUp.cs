using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemPickUp : MonoBehaviour
{

    public int puntosAdd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        UnityEngine.Debug.Log(col.name);
        if (col.name == "p1_stand")
        {
            puntajeController.AgregarPuntos(puntosAdd);
            Destroy(gameObject);
        }
    }
}
