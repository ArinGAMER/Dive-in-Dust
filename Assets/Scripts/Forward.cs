using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour {

	public float speed = 20f;

	void Update () {
		transform.localPosition += transform.forward * speed * Time.deltaTime;
	}
}
