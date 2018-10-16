using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

    static GameObject anterior;

    void OnMouseDown()
    {
        if (anterior != null )
        {           
            anterior.GetComponent<AudioSource>().Stop();
        }

        this.gameObject.GetComponent<AudioSource>().Play();
        anterior = this.gameObject;
    }
}
