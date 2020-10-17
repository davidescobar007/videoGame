using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirParticulas : MonoBehaviour
{
    private ParticleSystem sistemaDeParticula;

    // Start is called before the first frame update
    void Start()
    {
        sistemaDeParticula= GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sistemaDeParticula.isPlaying) {
            return;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
}
