using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiraGira : MonoBehaviour {


    public float x = 0, y = 0, z = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update() { 
        Vector3 rotacao = new Vector3(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime); // Time.deltaTime = Tempo desde o último update
        transform.Rotate(rotacao);
	}
}
