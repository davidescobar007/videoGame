using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoints : MonoBehaviour
{
    public levelController nivel;

    // Start is called before the first frame update
    void Start(){
        nivel = FindObjectOfType<levelController>();
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "p1_stand")
        {
            nivel.currentCheckpoint = gameObject;
        }
    }
}
