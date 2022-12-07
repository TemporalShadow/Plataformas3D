using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class SuperJumpPowerUp : MonoBehaviour
{
    [SerializeField]
    private int superJumpHeight = 20;

    [SerializeField]
    private int powerUpTime = 5;

    private TrailRenderer playerTrail;
    private ThirdPersonCharacter player;

    [SerializeField]
    private GameObject canvas;
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
        if (other.tag == "Player") {
            player= other.gameObject.GetComponent<ThirdPersonCharacter>();
            playerTrail = other.gameObject.GetComponent<TrailRenderer>();
            player.SetJumpHeight(superJumpHeight);
            playerTrail.enabled = true;
            GameObject.Find("Canvas").GetComponent<GUIManager>().StartPowerUpTimer(powerUpTime);
            //canvas.SetActive(true);
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;

            StartCoroutine(stopPoweUp());

            //this.gameObject.SetActive(false);
        }

        
        //Destroy(this.gameObject);
    }

    IEnumerator stopPoweUp()
    {
        yield return new WaitForSeconds(powerUpTime);
        player.SetJumpHeight(6);
        playerTrail.enabled = false;
        //canvas.SetActive(false);
        Destroy(this.gameObject);
    }
}
