using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	float deltaRotation = 30f;
	int movimiento;
	// Use this for initialization
	void Start () {
		//movimiento = Random.Range (0, 4);
		//print (movimiento);
	}
	
	// Update is called once per frame
	void Update () {
		//Rotate ();
		mover ();
	}

	void Rotate(){
		if(Input.GetKey(KeyCode.Q))
			transform.Rotate (new Vector3 (0f, -deltaRotation, 0f) * Time.deltaTime);
		else if(Input.GetKey(KeyCode.E))
			transform.Rotate (new Vector3 (0f, deltaRotation, 0f) * Time.deltaTime);
	}

	void mover(){
		if(Input.GetKey(KeyCode.F)){
			transform.Translate (Vector3.forward * 5 * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.G)){
			transform.Translate (Vector3.back * 5 * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.W)){
			transform.Translate (Vector3.up * 5 * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.S)){
			transform.Translate (Vector3.down * 5 * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.D)){
			transform.Translate (Vector3.right * 5 * Time.deltaTime);
		}		
		else if (Input.GetKey(KeyCode.A)){
			transform.Translate (Vector3.left * 5 * Time.deltaTime);
		}		
	}

	void OnColisionEnter(Collision collision)
	{
		Debug.Log (collision.gameObject.name);
	}	
		
}

