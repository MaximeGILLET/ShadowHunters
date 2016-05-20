using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Character :  NetworkBehaviour{

	public string name;
	public string type; //Shadow, hunter or neutral.
	public string VictoryCondition;
	public string Description;
	public int HealPoints;
	public int BaseDamage;
	public string[] Quotes;
	public Equipement[] Equiments;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
	

	}
}
