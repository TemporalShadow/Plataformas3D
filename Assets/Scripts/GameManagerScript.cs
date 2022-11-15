using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject spawnPoint;

    [SerializeField]
    private GameObject mundoVerde;

    [SerializeField]
    private GameObject mundoAzul;

    [SerializeField]
    private GameObject mundoRojo;

    [SerializeField]
    private GameObject mundoAmarillo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void command(string message) {
        switch (message)
        {
            case "RespawnPlayer":
                SpawnPlayer();
                break;
            case "NewSpawnPoint":
                setNewSpawnPoint();
                break;
            case "Azul":
                mundoAzul.SetActive(true);
                break;
        }
    }

    private void setNewSpawnPoint() {
        spawnPoint.transform.position= player.transform.position;
    }

    private void SpawnPlayer() {
        player.transform.position = spawnPoint.transform.position;
    }
}
