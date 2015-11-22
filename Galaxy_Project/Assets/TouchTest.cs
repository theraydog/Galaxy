using UnityEngine;
using System.Collections;

public class TouchTest : MonoBehaviour {

	Ray ray;
	RaycastHit hit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Is something touching?
		if (Input.touchCount > 0 ) {
			if (Input.GetTouch(0).phase == TouchPhase.Began) {
				ray = Camera.main.ScreenPointToRay(Input.GetTouch (0).position);
				Debug.DrawRay(ray.origin, ray.direction*200,Color.red);

				if (Physics.Raycast(ray, out hit, Mathf.Infinity)) {
					Debug.Log ("Hit " + hit.transform.tag + " !!");
				}
			}


			//Debug.Log (Input.touchCount);

			/*foreach(Touch touch in Input.touches) {
				Debug.Log (touch.position);
			}*/

			/*if (Input.GetTouch (0).position.x > (Screen.width/2)) {
				Debug.Log ("Right");
			}
			if (Input.GetTouch (0).position.x <= (Screen.width/2)) {
				Debug.Log ("Left");
			}*/

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
