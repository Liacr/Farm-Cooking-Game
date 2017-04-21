using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelecaoSemente : MonoBehaviour {

	public Transform cursorObj;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{

			
	}

	void OnMouseDown()
	{
		if (gameObject.name == "Repolho")
		{
			GameMaster.currentTool = "repolho";
			cursorObj.transform.position = transform.position;
		}

		if (gameObject.name == "Cebola")
		{
			GameMaster.currentTool = "cebola";
			cursorObj.transform.position = transform.position;
		}

		if (gameObject.name == "Tomate")
		{
			GameMaster.currentTool = "tomate";
			cursorObj.transform.position = transform.position;
		}

		if (gameObject.name == "Cenoura")
		{
			GameMaster.currentTool = "cenoura";
			cursorObj.transform.position = transform.position;
		}

		if (gameObject.name == "Batata")
		{
			GameMaster.currentTool = "batata";
			cursorObj.transform.position = transform.position;
		}
	}
}
