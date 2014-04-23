using UnityEngine;
using System.Collections;

public class Bola : MonoBehaviour {
	private bool pause = false;
	private int max =0;
	private int min =0;
	private int der =15;
	private int izq =-15;
	private int time =1;
	private bool enTierra = false;
	
	//private float temp = 0;
	private Vector3 vector;
	private Vector3 vecTemp;
	
	
	void Start () {
		this.constantForce.force = new Vector3(0f,-9.8f,0f);

	}
	

	void setValues(int maxAlto,int minAlto,int derech,int izquie) {
		max = maxAlto;
		min = minAlto;
		der = derech;
		izq = izquie;
	}
	
	public void increaseTime(){
		++time;
		//Debug.Log("nivel " + time);
		//this.constantForce.force.Set(0,-9.8*time,0);		
	}
	
	void Update () {
		if(pause==false){
			vector = rigidbody.velocity;
			if((this.transform.position.y >=min)||( this.transform.position.y < max)){
				//Perder
			}
			if((Input.GetKey("w"))&&(enTierra==true)){
				vector.y = 10f;
				rigidbody.velocity = vector;
			}
			if(Input.GetKey("a")){
				vector.x -= 0.2f*time;
				rigidbody.velocity = vector;
			}
			if(Input.GetKey("d")){
				vector.x += 0.2f*time;
				rigidbody.velocity = vector;
			}
			if(this.transform.position.x<izq){
				vecTemp.y=this.transform.position.y;
				vecTemp.x=-14f;
				vecTemp.z=0f;
				this.transform.position=vecTemp;
			}			
			if(this.transform.position.x>der){
				vecTemp.y=this.transform.position.y;
				vecTemp.x=14f;
				vecTemp.z=0f;
				this.transform.position=vecTemp;
			}
		}
	}
	
	void OnCollisionExit(Collision col){
		enTierra=false;
	}
	
	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Plataforms"){
			enTierra=true;
		}
		if(col.gameObject.tag == "Spikes"){
			//PERDER
		}
	}

	public static Bola M() {
		return FindObjectOfType(typeof(Bola)) as Bola;
	}	
}
