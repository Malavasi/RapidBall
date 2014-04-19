using UnityEngine;
using System.Collections;

public class Fuerza : MonoBehaviour {

	void OnMouseDown(){
		transform.position=new Vector3(transform.position.x,transform.position.y+2,transform.position.z);
	}
}
