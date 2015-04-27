using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {
	
	// Use this for initialization
	public float speed = 5f;
	public Vector2 maxSpeed = new Vector2(3,5);
	public int direction = 1;
	//private int Count = 1;
	// Update is called once per frame
	void Update () {
		
		var forceX = 0f;
		var forceY = 0f;

		var absVelX = Mathf.Abs (rigidbody2D.velocity.x);
		if (Input.GetKey (KeyCode.A)) {
			
						if (absVelX < maxSpeed.x) {
								forceX = -speed;
						}
						direction = 1;
						transform.localScale = new Vector3 (direction, 1, 1);
				}

	   if(Input.GetKey(KeyCode.Space)){

				if(direction > 0 ){
					forceX = -speed*20;}
				else{
					forceX= speed*20;}
	     	
		//Count = Count*2;		
		} else if(Input.GetKey (KeyCode.D)){
			
			if(absVelX < maxSpeed.x ) {
				forceX = speed;}
			direction = -1;
			transform.localScale = new Vector3(direction,1,1);}
		
		
		
		rigidbody2D.AddForce (new Vector2( forceX,forceY));
		
		
		
	}
}