using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneScript : MonoBehaviour {

    public GameObject switchCamera;
    public GameObject fenceCamera;
    public GameObject fence;

    GameObject mainCamera;

    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void StartCutscene()
    {
        print("StartCutscene");

        // Cambiar la cámara activa
        mainCamera.SetActive(false);
        switchCamera.SetActive(true);
    }

    void ChangeCamera1()
    {
        print("ChangeCamera1");

        // Cambiar la cámara activa
        switchCamera.SetActive(false);
        fenceCamera.SetActive(true);
    }

    void DeactivateBarrier()
    {
        print("DeactivateBarrier");

        fence.SetActive(false);
    }

    void ChangeCamera2()
    {
        print("ChangeCamera2");

        // Restituir cámara por defecto
        fenceCamera.SetActive(false);
        mainCamera.SetActive(true);

    }

}
