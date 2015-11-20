using UnityEngine;
using System.Collections;

public class Ship_Player : MonoBehaviour {


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		//Is something touching?
		if (Input.touchCount > 0) {
			//Debug.Log (Input.touchCount);
			
			
			/*foreach(Touch touch in Input.touches) {
				Debug.Log (touch.position);
			}*/
			
			if (Input.GetTouch (0).position.x > (Screen.width/2)) {
				Debug.Log ("Right");
				transform.Translate(Vector3.right );
			}
			if (Input.GetTouch (0).position.x <= (Screen.width/2)) {
				Debug.Log ("Left");
				transform.Translate(Vector3.left);

			}

		}
	}

	void FixedUpdate() {

	}
}