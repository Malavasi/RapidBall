using UnityEngine;
using System.Collections;

public class Bola : MonoBehaviour {
	private bool pause = false;
	private int max =0;
	private int min =0;
	private float aceleracion = 0;
	private int time =1;
	public int arriba =5;
	public int lateral =1;

	public int tempX;
	public int tempY;
	public int tempZ;
	
	void Start () {
	}
	

	void setValues(int max1,int min1) {
		max = max1;
		min = min1;
	}
	
	public void increaseTime(){
		++time;
		this.constantForce.force.Set(0,-1*time,0);
	}
	
	void Update () {
		if(pause==false){
			if((this.transform.position.y >=min)||( this.transform.position.y < max)){
				//Perder
			}
			if(Input.GetKey("w")){//PD: evitar que salte en el aire....
				rigidbody.velocity.Set(rigidbody.velocity.x, rigidbody.velocity.y + (arriba*time),rigidbody.velocity.z);
				Debug.Log("FUNCIONA");
			}
			if(Input.GetKey("a")){
			//	this.rigidbody.velocity.x+=lateral*time;
			}
			if(Input.GetKey("d")){
			//	this.rigidbody.velocity.x-=lateral*time;
			}
		}
	}
	
	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "spike"){
			//PERDER
		}
	}

	public static Bola M() {
		return FindObjectOfType(typeof(Bola)) as Bola;
	}	
}
