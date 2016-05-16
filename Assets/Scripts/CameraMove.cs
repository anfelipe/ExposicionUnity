using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public float minX = -360.0f;
	public float maxX = 360.0f;

	public float minY = -45.0f;
	public float maxY = 45.0f;

	public float sensX = 100.0f;
	public float sensY = 100.0f;

	public float rotationX = 0.0f;
	public float rotationY = 0.0f;

	private float zoomSpeed = 2.0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float scroll = Input.GetAxis ("Mouse ScrollWheel");
		transform.Translate (0, scroll * zoomSpeed, scroll * zoomSpeed, Space.World);

		if(Input.GetMouseButton (0)){
			rotationX += Input.GetAxis ("Mouse X") * sensX * Time.deltaTime;
			rotationY += Input.GetAxis ("Mouse Y") * sensY * Time.deltaTime;
			rotationY = Mathf.Clamp (rotationY, minY, maxX);
			transform.localEulerAngles = new Vector3 (-rotationY, rotationX, 0);
		}

		if(Input.GetKey(KeyCode.RightArrow)){
			transform.position += Vector3.right * zoomSpeed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.position += Vector3.left * zoomSpeed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.position += Vector3.forward * zoomSpeed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.position += Vector3.back * zoomSpeed * Time.deltaTime;
		}

	}
}
