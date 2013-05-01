using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {
	/** Attributes */
	//Public
	public Camera myCamera;
	public string objectName;
	public string urlToOpen;
	
	//Private
	private RaycastHit hit;
	private Ray ray;
	
	
	
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount==1){
			Debug.Log("Single touch intercepted");
			Touch touch = Input.touches[0];
			//Proyection form the camera
			ray = myCamera.ScreenPointToRay(Input.touches[0].position);
			//Check touch phase and raycast
			if(touch.phase == TouchPhase.Ended && Physics.Raycast(ray.origin,ray.direction,out hit)){
				Debug.Log("Object ->"+hit.collider.name +" touched");
	            if(hit.collider.name.Equals(objectName)){
					Application.OpenURL (urlToOpen);
				}
	        }
			
		}
	}
	
}





