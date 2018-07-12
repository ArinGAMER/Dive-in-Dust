using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Material skyBox;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(skyBox != null)
        skyBox.SetFloat("_Rotation", Time.time * Time.deltaTime);
	}
}
