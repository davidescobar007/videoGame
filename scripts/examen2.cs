using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examen2 : MonoBehaviour
{
    public GameObject Munecos;
    public float time = 2f, RangoCreacion = 2f;
    void Start()
    {
        InvokeRepeating("Creando", 0.0f, time);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Creando()
    {

        Vector3 SpawnPosition = new Vector3(0, 0, 0);
        SpawnPosition = this.transform.position + Random.onUnitSphere * RangoCreacion;
        SpawnPosition = new Vector3(SpawnPosition.x, SpawnPosition.y, 0);

        GameObject Muneco = Instantiate(Munecos, SpawnPosition, Quaternion.identity);
    }
}
