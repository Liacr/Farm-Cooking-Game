using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utensilios : MonoBehaviour {

	public Transform cursorObj;
	public Transform sementeInvObj;
	public Transform botaoSementeInv;
	public Transform utensiliosInv;

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
			cursorObj.transform.position = transform.position; //Pega a posição do cursor e passa para a posição do objeto que está com o script
		}

		if (gameObject.name == "Sementinha") 
		{
			GameMaster.currentTool = "Sementinha";
			sementeInvObj.transform.position = new Vector3 (-4, 1); //posicao que o inventario vai abrir
			botaoSementeInv.transform.position = new Vector3 (-5, 1);
			cursorObj.transform.position = transform.position;
		}

		if (gameObject.name == "Regador") 
		{
			GameMaster.currentTool = "Regador";
			cursorObj.transform.position = transform.position; //Pega a posição do cursor e passa para a posição do objeto que está com o script
		}

		if (gameObject.name == "BotaoSementeInv") //fecha parte das sementes
		{
			sementeInvObj.transform.position = new Vector3 (-7, 1);
			botaoSementeInv.transform.position = new Vector3 (-8, 1);
			cursorObj.transform.position = transform.position;
		}

		if (gameObject.name == "AbrirInv") //abre tudo
		{
			utensiliosInv.transform.position = new Vector3 (-6, 1);
			cursorObj.transform.position = transform.position;
		}

		if (gameObject.name == "FecharInv") //fecha tudo
		{
			sementeInvObj.transform.position = new Vector3 (-8, 1);
			botaoSementeInv.transform.position = new Vector3 (-7, 1);
			utensiliosInv.transform.position = new Vector3 (-9, 1);
			cursorObj.transform.position = transform.position;
		}
			

		Debug.Log (GameMaster.currentTool);
	}
}
