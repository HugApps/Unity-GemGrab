using UnityEngine;
using System.Collections;
// Enables a list to be used
using System.Collections.Generic;



public class HelloWorld : MonoBehaviour {
	// Global Variaables
	public float speed;
	public List<string> list = new List<string>();
	// Use this for initialization
	void Start () {
				list.Add ("hi");
				list.Add ("bob");
				var phrase = list [0] + list [1];
				print (phrase); 
		}
	// Update is called once per frame
	// update logic before rendering , determinig future locations, life, fuel etc continouslly happen
	void Update () {

		//Transform position
		speed =2f;
		transform.Translate (new Vector3 (speed, 0, transform.position.z) * Time.deltaTime);

	
	}
}
