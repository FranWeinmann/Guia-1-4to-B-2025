using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{

    public string monedaExtranjera;
    public float monto;
    float cotizacionDolar = 1290f;
    float cotizacionReales = 183.73f;
    float cotizacionEuro = 1179.07f;
    float montoMinimo = 1000;
    float montoConvertido;
    float cotizacionMonedaElegida;
    string detallito;

    // Start is called before the first frame update
    void Start()
    {
        if (monto < montoMinimo)
        {
            Debug.Log("El monto mínimo es $1000");
            return;
        }
        if (monedaExtranjera == "D")
        {
            cotizacionMonedaElegida = cotizacionDolar;
            detallito = "Dólares";
        } else if(monedaExtranjera == "R")
        {
            cotizacionMonedaElegida = cotizacionReales;
            detallito = "Reales";
        } else if(monedaExtranjera == "E")
        {
            cotizacionMonedaElegida = cotizacionEuro;
            detallito = "Euros";
        }
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }
        montoConvertido = monto / cotizacionMonedaElegida;
        Debug.Log("El monto ingresado equivale a " + montoConvertido + " " + detallito);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
