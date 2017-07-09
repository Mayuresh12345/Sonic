using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 8f ,  maxvelocity = 12f;
	[SerializeField]
	private Rigidbody2D myBody;
	private Animator anim;	
	// Use this for initialization
	void Awake()
	{
		myBody = GetComponent<Rigidbody2D> ();
 		anim = GetComponent<Animator> ();
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		PlayerMoveKeyboard ();
	}

	void PlayerMoveKeyboard ()
	{
		float forceX = 0;
		float vel = Mathf.Abs (myBody.velocity.x);
		float h = Input.GetAxisRaw ("Horizontal");			//return -1 up and left 0 for nothing 1 for right or d
		if (h > 0) {
			if (vel < maxvelocity) {
				forceX = speed;				//right
					
			}
			Vector3 temp = transform.localScale;
			temp.x = 1.3f;
			transform.localScale = temp;
			anim.SetBool ("Walk", true);

		} else if (h < 0) {
			if (vel < maxvelocity) {
				forceX = -speed;			//left
		
			}
			Vector3 temp = transform.localScale;
			temp.x = -1.3f;
			transform.localScale = temp;

			anim.SetBool ("Walk", true);
		} else {
			anim.SetBool ("Walk", false);
		}
		myBody.AddForce (new Vector2 (forceX,0));

	}

}
// Player
