using UnityEngine;
using System.Collections;

public class TouchTest : MonoBehaviour {

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
			}
			if (Input.GetTouch (0).position.x <= (Screen.width/2)) {
				Debug.Log ("Left");
			}

			/*if(Input.GetTouch (0).phase == TouchPhase.Began) {
				Debug.Log ("Touch Began");
			}

			if(Input.GetTouch (0).phase == TouchPhase.Moved) {
				Debug.Log ("Touch Moved");
			}

			if(Input.GetTouch (0).phase == TouchPhase.Ended) {
				Debug.Log ("Touch Ended");
			}*/
		}
	
	}
}
