using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceTextureOffsetScript : MonoBehaviour {

    public float scrollSpeed = 0.25f;
    
    void Update () {
        var offset = scrollSpeed * Time.deltaTime;
        Renderer r = GetComponent<Renderer> ();
        r.material.mainTextureOffset += new Vector2(offset,offset);
    }

}
