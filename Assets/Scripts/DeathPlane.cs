using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour
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
        //Debug.Log("Muerto");
        if (other.tag == "Player")
        {
            /*Player miPlayer = collision.GetComponent<Player>();
            if (miPlayer != null)
            {*/
            GameManagerScript gameManager= GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerScript>();
            gameManager.command("RespawnPlayer");
            /*Vector3 vector3 = new Vector3(4, 1, -6);
            other.gameObject.transform.position = vector3;*/
            Debug.Log("Muerto");
            //}
        }
    }


}
