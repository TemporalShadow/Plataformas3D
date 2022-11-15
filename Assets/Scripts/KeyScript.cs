using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
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
        GameManagerScript gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerScript>();
        gameManager.command("NewSpawnPoint");
        gameManager.command("Azul");
        this.gameObject.SetActive(false);
    }

}
