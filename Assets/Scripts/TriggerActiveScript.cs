using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActiveScript : MonoBehaviour
{

    [SerializeField]
    private GameObject mundito;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            activarMundo();
        }
    }

    void activarMundo() { 
        mundito.SetActive(true);
    }
}
