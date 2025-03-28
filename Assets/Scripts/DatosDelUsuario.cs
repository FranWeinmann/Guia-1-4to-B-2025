using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{

    public string userName;
    public int userAge;
    public float userHeigth;
    public bool esDonante;

    // Start is called before the first frame update
    void Start()
    {
        if (esDonante)
        {
            Debug.Log("Mi nombre es " + userName + ", tengo " + userAge + ", mido " + userHeigth + "m y es verdad que soy donante de órganos");
        }
        else
        {
            Debug.Log("Mi nombre es " + userName + ", tengo " + userAge + ", mido " + userHeigth + "m y es mentira que soy donante de órganos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
