using UnityEngine;
using System.Collections;

public class oppositewalk : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float speed =2f;
		transform.Translate (0,0, speed * Time.deltaTime);


	
	}
}
