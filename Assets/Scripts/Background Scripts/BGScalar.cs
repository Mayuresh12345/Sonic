using UnityEngine;
using System.Collections;

public class BGScalar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SpriteRenderer sr = GetComponent<SpriteRenderer> ();
		Vector3 tempscale = transform.localScale;

		float width = sr.sprite.bounds.size.x;
		float worldHeight = Camera.main.orthographicSize * 2.0f;
		float worldWidth = worldHeight / Screen.height * Screen.width;

		tempscale.x = worldWidth / width;
		transform.localScale = tempscale;

	}
	
}
