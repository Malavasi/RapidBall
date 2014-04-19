using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float velocidad = 0.1f;

	// Update is called once per frame
	void Update () {
		if(Input.GetKey("w")){
				transform.position=new Vector3(transform.position.x,transform.position.y,transform.position.z+velocidad);
			}
		if(Input.GetKey("a")){
				transform.position=new Vector3(transform.position.x-velocidad,transform.position.y,transform.position.z);
			}
		if(Input.GetKey("s")){
				transform.position=new Vector3(transform.position.x,transform.position.y,transform.position.z-velocidad);
			}
		if(Input.GetKey("d")){
				transform.position=new Vector3(transform.position.x+velocidad,transform.position.y,transform.position.z);
			}
		}
}
