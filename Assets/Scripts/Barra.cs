using UnityEngine;
using System.Collections;

public class Barra : MonoBehaviour {

	int con = 0;
	public GameObject barra, cuboH, cylinder;
	public Transform explosion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		/*ContactPoint contact = collision.contacts [0];

		Quaternion rot = Quaternion.FromToRotation (Vector3.up, contact.normal);
		Vector3 pos = contact.point;
		Instantiate (explosion, pos, rot);
		//Destroy (gameObject);
		Debug.Log("It is:" + gameObject);*/

		if(collision.gameObject.name.Equals("Piedra(Clone)")){
			con++;

			if(con == 3)
			{
				barra = GameObject.Find ("Barra");
				Destroy (barra);
				cylinder = GameObject.Find ("Cylinder");
				Destroy (cylinder);
				//Debug.Log ("Romper");
				Destroy (gameObject);

			}
		}
		Debug.Log (collision.gameObject.name);
	}
}
