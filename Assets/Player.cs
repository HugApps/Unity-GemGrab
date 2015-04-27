using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	public float speed = 5f;
	public bool standing;
	// AirSpeedDrag
	public float Drag = 0.5f;
	public Vector2 maxSpeed = new Vector2(3,5);
	public float jetSpeed = 15f;
	public int direction = 1;
	private Animator animator;
	//private int  Count = 1;
	// Update is called once per frame

	void Start (){
				// gets refrence to animator//
				animator = GetComponent<Animator> ();
		        
		}
	void Update () {


		animator.SetInteger ("AnimState", 0);
		animator.SetInteger ("jetting", 0);
		var forceX = 0f;
		var forceY = 0f;

		var absVelX = Mathf.Abs (rigidbody2D.velocity.x);
		var absVelY = Mathf.Abs (rigidbody2D.velocity.y);


		// Check if airborne or not //

		if (absVelY < .3f) {
						standing = true;
				} else {
						standing = false;
				}

		if (Input.GetKey ("up")) {
			if(absVelY < maxSpeed.y) {
				forceY = jetSpeed+10;}
			animator.SetInteger("jetting",1);		
				}
		if(Input.GetKey ("right")){

			if(absVelX < maxSpeed.x ) {
				forceX = standing ? speed : (speed*Drag);
				direction = 1;}

			animator.SetInteger(standing ? "AnimState" : "jetting",1);
		
			transform.localScale = new Vector3(1,1,1);
		}
		
		if(Input.GetKey(KeyCode.RightShift)){
			
			if(direction > 0 ){
				forceX = speed*20;}
			else{
				forceX= -speed*20;}


			//Count = Count*2;
		} else if(Input.GetKey ("left")){
			
			if(absVelX < maxSpeed.x ) {
				forceX = standing ? -speed : (-speed*Drag);
				direction = -1;}

			animator.SetInteger(standing ? "AnimState" : "jetting",1);
			transform.localScale = new Vector3(-1,1,1);}


		rigidbody2D.AddForce (new Vector2( forceX,forceY));



}
}