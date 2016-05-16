#pragma strict

var vel : int = 3;
var objeto : Transform;
var prefabBullet : Rigidbody;
public var explosion: Transform;
var cubo : GameObject;

function Start () {

}

function Update () {
	if (Input.GetKeyDown("mouse 1")){
		//var generar = Instantiate(prefabBullet, GameObject.Find("SpawnBullet").transform.position, Quaternion.identity);
		var generar = Instantiate(objeto, transform.position, Quaternion.identity);

		generar.GetComponent.<Rigidbody>().AddForce(transform.forward * 2000);

		cubo = GameObject.Find("Piedra(Clone)");
		Destroy(cubo, 1f);
	}
}

function OnCollisionEnter(collision: Collision){
	Debug.Log ("sadsa");

	var contact: ContactPoint = collision.contacts[0];

	var rot: Quaternion = Quaternion.FromToRotation(Vector3.up, contact.normal);
	var pos: Vector3 = contact.point;
	Instantiate(explosion, pos, rot);
	Destroy(gameObject);
	Debug.Log (collision.gameObject.name);
}
