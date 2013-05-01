using UnityEngine;
using System.Collections;

/**
 * Script created to control where the user touch in the screen and proyect
 * this touch into the scene.
 * If you want to use this script yo have to add a collider to your object
 * and rename it. Then create an empty objetc ant attach this script to it.
 * When you have the collider prepared configure the script in the inspector
 * with the name of the object and the url to open.
 * 
 * */
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





