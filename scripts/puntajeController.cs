using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
public class puntajeController : MonoBehaviour
{
    public static int puntaje;
    Text texto;

    // Start is called before the first frame update
    void Start()
    {
        texto = GetComponent<Text>();
        puntaje = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(puntaje < 0){
            puntaje = 0;
        }else{
            texto.text = "" + puntaje;
        }
    }

    public static void AgregarPuntos(int puntosParaAgregar){
        puntaje += puntosParaAgregar;
    }

    public static void Reset() {
        puntaje = 0;
    }
}
