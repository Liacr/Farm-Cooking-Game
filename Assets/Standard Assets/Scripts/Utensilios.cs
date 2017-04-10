using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utensilios : MonoBehaviour {

	public Transform cursorObj;

	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnMouseDown() //clicar no objeto que temos para usar certo item...
	{
		if(gameObject.name == "Pa")
		{
			GameMaster.currentTool = "Pa";
		}

		if (gameObject.name == "Sementinha") 
		{
			GameMaster.currentTool = "Sementinha";
		}

		if (gameObject.name == "Regador") 
		{
			GameMaster.currentTool = "Regador";
		}

		//Pega a posição do cursor e passa para a posição do objeto que está com o script
		cursorObj.transform.position = transform.position;

		Debug.Log (GameMaster.currentTool);
	}
}
