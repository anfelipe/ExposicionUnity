using UnityEngine;
using System.Collections;

public class MoveRigibody : MonoBehaviour {

	int con = 0;
	public GameObject barra;

	void FixedUpdate()
	{
		
	}	

	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.name.Equals("Barra")){
			con++;

			if(con == 3)
			{
				Debug.Log ("Romper");
				barra = GameObject.Find ("Barra");
				Destroy (barra);
			}
		}
		//Debug.Log (collision.gameObject.name);
	}

	void OnCollisionExit(Collision collision)
	{
		
	}		
}
