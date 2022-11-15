using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MovingPlataform : MonoBehaviour
{
    /*[SerializeField]
    private GameObject wayPoint1;
    
    [SerializeField]
    private GameObject wayPoint2;

    [SerializeField]
    private int speed = 10;

    private float time;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = wayPoint1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        movimiento();
    }

    private void movimiento()
    {
        time += Time.deltaTime * speed;

        transform.position = Vector3.Lerp(wayPoint1.transform.position, wayPoint2.transform.position,time);

        if (time >= 1)
        {
            var a = wayPoint2;
            var b = wayPoint1;

            wayPoint1 = a;
            wayPoint2 = b;

            time = 0;
        }
    }*/

    [SerializeField]
    private Transform waypoint1, waypoint2;

    private Transform target;

    [SerializeField]
    private float error = 0.1f;

    [SerializeField]
    private float speed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        target = waypoint2;
    }

    // Update is called once per frame
    void Update()
    {
        // calcular direcci?n del movimiento
        Vector3 dir = target.position - transform.position;
        float distancia = dir.magnitude;

        // normalizar (tama?o 1)
        dir.Normalize();

        // desplazamiento en funci?n de la velocidad y el tiempo
        Vector3 despl = dir * speed * Time.deltaTime;
        this.transform.Translate(despl);

        // comprobar si he llegado
        if (distancia < error)
        {
            // cambiar de target
            if (target == waypoint2)
                target = waypoint1;
            else
                target = waypoint2;
        }
    }
}
