using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject target;
	
	public GameObject leftWall;
	public  GameObject rightWall;
	public GameObject bottomWall;
	public GameObject topWall;
	
	private Vector3 targetPosition;
	public float smoothing;
	
	Camera mainCamera;

	// Use this for initialization
	void Start () {
		mainCamera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void FixedUpdate(){

		//if(Vector3.Distance(target.transform.position, topWall.transform.position) < 130f)
		//{
		//	targetPosition = new Vector3(target.transform.position.x, target.transform.position.y + 10, -10);
		//	Debug.Log(1);

		//}
		if(Vector3.Distance(target.transform.position, leftWall.transform.position) < 70f)
		{
			targetPosition = new Vector3(target.transform.position.x - 8, target.transform.position.y, -10);
			if(mainCamera.orthographicSize < 38){	
				mainCamera.orthographicSize = mainCamera.orthographicSize + 1.15f*Time.deltaTime;
			}
			
			Debug.Log(2);

		}
		//else if(Vector3.Distance(target.transform.position, bottomWall.transform.position) < 130f)
		//{
		//	targetPosition = new Vector3(target.transform.position.x, target.transform.position.y - 10, -10);
		//	Debug.Log(10);

		//}
		//else if((Vector3.Distance(target.transform.position, leftWall.transform.position) < 130f) && Vector3.Distance(target.transform.position, bottomWall.transform.position) < 130f)
		//{
		//	targetPosition = new Vector3(target.transform.position.x - 10, target.transform.position.y - 10, -10);
		//	Debug.Log(2);
		//}
		//else if((Vector3.Distance(target.transform.position, leftWall.transform.position) < 130f)  && (Vector3.Distance(target.transform.position, topWall.transform.position) < 130f))
		//{
		//	targetPosition = new Vector3(target.transform.position.x - 10, target.transform.position.y + 10, -10);
		//	Debug.Log(3);
		//}
		else if(Vector3.Distance(target.transform.position,rightWall.transform.position) < 70f)
		{
			targetPosition = new Vector3(target.transform.position.x + 8, target.transform.position.y, -10);
			if(mainCamera.orthographicSize < 38){	
				mainCamera.orthographicSize = mainCamera.orthographicSize + 1.15f*Time.deltaTime;
			}
			Debug.Log(5);

		}
		//else if((Vector3.Distance(target.transform.position, rightWall.transform.position) < 130f) &&(Vector3.Distance(target.transform.position, topWall.transform.position) < 130f))
		//{
		//	targetPosition = new Vector3(target.transform.position.x + 10, target.transform.position.y + 10, -10);
		//	Debug.Log(4);
		//}
		
		//else if((Vector3.Distance(target.transform.position, rightWall.transform.position) < 130f) &&(Vector3.Distance(target.transform.position, bottomWall.transform.position) < 130f))
		//{
		//	targetPosition = new Vector3(target.transform.position.x + 10, target.transform.position.y - 10, -10);
		//	Debug.Log(6);
		//}
		else
		{
			targetPosition = new Vector3(target.transform.position.x, target.transform.position.y, -10);
			if(mainCamera.orthographicSize > 35){	
				mainCamera.orthographicSize = mainCamera.orthographicSize - 1.15f*Time.deltaTime;
				Debug.Log(7);
			}
		}
		
		transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime);
	}
}
