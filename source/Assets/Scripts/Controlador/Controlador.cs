using UnityEngine;
using System.Collections;

public class Controlador : MonoBehaviour {

	private float speed = 1f;
	private int time = 0;
	
	public int alto = 100; // |
	public int ancho = 100; // -
	
	private Bola bolita;
	
	void Start () {
		bolita = Bola.M();
	}
	
	void Update () {
		aumentarVelocidad();
		//Debug.Log(time);
		//Debug.Log(Random.Range(0,10));
	}
	
	void aumentarVelocidad(){
		++time;
		if(time==1000){
			time=0;
			time+=1;
			bolita.increaseTime();
		}
	}
}
