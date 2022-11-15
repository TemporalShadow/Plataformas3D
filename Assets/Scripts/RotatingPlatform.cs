using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    public Vector3 rotateVector;
    public float speed;
    private float stopstart = 1;

    public bool endless = true;
    public float timeRotating = 10f, timePause = 5f;

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

        
    }

    void Update()
    {    
        // Rotar a la velocidad indicada
        float angle = Time.deltaTime * speed* stopstart;
        transform.Rotate(rotateVector * angle);
    }
    
}
