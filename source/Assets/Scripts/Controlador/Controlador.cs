using UnityEngine;
using System.Collections;

public class Controlador : MonoBehaviour {


	private int time = 0;
	GameObject[] plataformas;
	GameObject[] spikes;
	
	
	public int alto = 16; // |
	public int ancho = 20; // -
	public int numPlataform = 4;
	public int numSpikes = 3;
	
	private Bola bolita;
	private Vector3 vector;
	
	void Start () {
		bolita = Bola.M();
		plataformas = new GameObject[numPlataform];
		spikes = new GameObject[numSpikes];
		for(int x=0;x<numPlataform;++x){
			plataformas[x] = (GameObject)Instantiate((GameObject)Resources.Load("Plataforma0"));
		}
		for(int y=0;y<numSpikes;++y){
			spikes[y] = (GameObject)Instantiate((GameObject)Resources.Load("Spikes0"));
		}
		vector.y=0;
		vector.x=0;
		vector.z=0;
	}
	
	void Update () {
		aumentarVelocidad();
		moverPlataformas();
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
	
	void moverPlataformas(){
		for(int x1=0;x1<numPlataform;++x1){	
		Debug.Log(x1);
			if(plataformas[x1].transform.position.y>alto){//16
			vector.y=Random.Range((-1*ancho),ancho);
			vector.y=Random.Range((-1*alto),(-2*alto));
			}else{
			vector.y=plataformas[x1].transform.position.y+time;
			vector.x=(plataformas[x1].transform.position.x);
			plataformas[x1].transform.Translate(vector);
			}
		}
		for(int y1=0;y1<numSpikes;++y1){
			if(plataformas[y1].transform.position.y>alto){//16
				vector.y=Random.Range((-1*ancho),ancho);
				vector.y=Random.Range((-1*alto),(-2*alto));
			}else{
				vector.y=spikes[y1].transform.position.y+time;
				vector.x=(spikes[y1].transform.position.x);
				spikes[y1].transform.Translate(vector);
			}
		}
	}
}
