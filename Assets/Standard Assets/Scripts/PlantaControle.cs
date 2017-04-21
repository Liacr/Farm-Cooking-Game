using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantaControle : MonoBehaviour {

	public Sprite semPlantaObj;

	public Sprite repolho;
	public Sprite repolho2;
	//public Sprite terraComAgua;

	public Sprite batata;
	public Sprite batata2;

	public Sprite cebola;
	public Sprite cebola2;

	public Sprite cenoura;
	public Sprite cenoura2;

	public Sprite tomate;
	public Sprite tomate2;

	public float tempoCrescimento = 0;

	public Transform lote;
	public bool comAgua = false;

	public string sementeAtual = "";

	void Start () 
	{
		
	}

	void Update () 
	{	
	
		//Checa se está no sprite inicial de cada planta (brotinho), aumenta o tempo de crescimento, ao ultrapassar 5s a sprite muda.
		
		if (sementeAtual != "")
		{
			tempoCrescimento += Time.deltaTime;
		}

		//Checa se a tem água se não tiver a sprite volta a ficar nula
		if ((tempoCrescimento > 5f) && (comAgua == false)) //sem água
		{
			sementeAtual = "";
			tempoCrescimento = 0; //volta para zero
			GetComponent<SpriteRenderer> ().sprite = semPlantaObj; //brotinho morre
		}

		if ((tempoCrescimento > 5f) && (comAgua == true)) //COM ÁGUA
		{
			//----------BROTINHOS JÁ FORAM REGADOS x3-------------
		//----------------------------PLANTAS CRESCIDAS AQUI-------------------------------------
			if (sementeAtual == "repolho") 
			{
				GetComponent<SpriteRenderer>().sprite = repolho2;
			}

			if (sementeAtual == "cebola") 
			{
				GetComponent<SpriteRenderer>().sprite = cebola2;
			}

			if (sementeAtual == "tomate") 
			{
				GetComponent<SpriteRenderer>().sprite = tomate2;
			}

			if (sementeAtual == "cenoura") 
			{
				GetComponent<SpriteRenderer>().sprite = cenoura2;
			}

			if (sementeAtual == "batata") 
			{
				GetComponent<SpriteRenderer>().sprite = batata2;
			}

		//----------------------------FIM DAS PLANTAS-------------------------------------
		
		}
			
	}

	void OnMouseDown() //Se clicar na planta, sprite muda (botei uma sprite null)
	{
		Debug.Log ("clicou na plantinha");
		if (GameMaster.currentTool == "Pa") // com a pá
		{
			//Destroy (gameObject);
			GetComponent<SpriteRenderer>().sprite = semPlantaObj;
		}
			
		//----------------------------PLANTAR BROTINHOS AQUI----------------------------------

		if ((GameMaster.currentTool == "repolho") && (GetComponent<SpriteRenderer>().sprite == semPlantaObj)) // com a semente e com a sprite null
		{
			GetComponent<SpriteRenderer>().sprite = repolho;
			sementeAtual = "repolho"; //variavel para o que está sendo plantado
		}

		if ((GameMaster.currentTool == "cebola") && (GetComponent<SpriteRenderer>().sprite == semPlantaObj)) // com a semente e com a sprite null
		{
			GetComponent<SpriteRenderer>().sprite = cebola;
			sementeAtual = "cebola";
		}

		if ((GameMaster.currentTool == "tomate") && (GetComponent<SpriteRenderer>().sprite == semPlantaObj)) // com a semente e com a sprite null
		{
			GetComponent<SpriteRenderer>().sprite = tomate;
			sementeAtual = "tomate";
		}

		if ((GameMaster.currentTool == "cenoura") && (GetComponent<SpriteRenderer>().sprite == semPlantaObj)) // com a semente e com a sprite null
		{
			GetComponent<SpriteRenderer>().sprite = cenoura;
			sementeAtual = "cenoura";
		}

		if ((GameMaster.currentTool == "batata") && (GetComponent<SpriteRenderer>().sprite == semPlantaObj)) // com a semente e com a sprite null
		{
			GetComponent<SpriteRenderer>().sprite = batata;
			sementeAtual = "batata";
		}

		//-------------------------------FIM DOS BROTINHOS-----------------------------------

		if ((GameMaster.currentTool == "Regador") && (GetComponent<SpriteRenderer>().sprite != semPlantaObj))
			// com o regador muda a cor pra ciano
		{
			
			lote.GetComponent<SpriteRenderer>().color = new Color (0, 1, 1, 1);
			//lote.GetComponent<SpriteRenderer>().sprite = terraComAgua;
			comAgua = true; //com agua o brotinho cresce
		}
	}
}
