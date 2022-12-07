using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    public Vector3 rotateVector;
    public float speed;
    private float stopstart = 1;
    
    [SerializeField]
    private int tiempoRotar = 5;
    [SerializeField]
    private int tiempoPausar = 5;


    public bool endless = true;
    public float timeRotating = 10f, timePause = 5f;
    private bool bRotar = true;

    //falta por rellenar:
    /*
        El objetivo es realizar un script que dependiendo del bool endless realice:
        true: nunca deja de girar
        false: gira durante el tiempo timeRotating, luego no gira durante timePause y despues vuelve a girar

        Pista: Mirar el funcionamiento de las variables
    */

    void Start()
    {
        rotateVector.Normalize();

        if(!endless)
            StartCoroutine(rotar());

    }

    void Update()
    {
        float angle = Time.deltaTime * speed * stopstart;
        if(bRotar)
            transform.Rotate(rotateVector * angle);
        // Rotar a la velocidad indicada

    }

    IEnumerator rotar()
    {
        
        yield return new WaitForSeconds(tiempoRotar);
        bRotar = false;
        StartCoroutine(pausar());
    }
    
    IEnumerator pausar()
    {
        
        yield return new WaitForSeconds(tiempoPausar);
        bRotar = true;
        StartCoroutine(rotar());
    }

}
