using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculosPersonalizados : MonoBehaviour
{

    public enum options
    {
        Suma,
        Resta,
        Dividir,
        Multiplicar
    }

    public options opcion;
    public float num1;
    public float num2;

    // Start is called before the first frame update
    void Start()
    {
        float resultadoSuma = num1 + num2;
        float resultadoResta = num1 - num2;
        float resultadoMultiplicacion = num1 * num2;
        float resultadoDivision = num1 / num2;
        Debug.Log("El resultado de la suma entre " + num1 + " y " + num2 + ", es: " + resultadoSuma + ". " + 
            "El resultado de la resta entre " + num1 + " y " + num2 + ", es: " + resultadoResta + ". " +
            "El resultado de la multiplicación entre " + num1 + " y " + num2 + ", es: " + resultadoMultiplicacion + ". " +
            "El resultado de la división entre " + num1 + " y " + num2 + ", es: " + resultadoDivision + ". ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
