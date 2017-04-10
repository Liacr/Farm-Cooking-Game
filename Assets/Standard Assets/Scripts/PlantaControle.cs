using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantaControle : MonoBehaviour {

	public Sprite semPlantaObj;
	public Sprite florBrotinho;
	public Sprite florFinal;
	//public Sprite terraComAgua;

	public float tempoCrescimento = 0;

	public Transform lote;
	public bool comAgua = false;

	void Start () 
	{
		
	}

	void Update () 
	{	//Checa se está na florBrotinho, aumenta o tempo de crescimento, ao ultrapassar 3s a sprite muda.
		//Acredito que isso de checar a cada frame não pode, como proceder? *É o tempo que vai levar p crescer
		if (GetComponent<SpriteRenderer> ().sprite == florBrotinho)
		{
			tempoCrescimento += Time.deltaTime;
		}

		if (tempoCrescimento > 5f)
		{
			if (comAgua == true) {
				GetComponent<SpriteRenderer> ().sprite = florFinal;
			} 
			else 
			{
				tempoCrescimento = 0;
				GetComponent<SpriteRenderer> ().sprite = semPlantaObj;
			}
		}

		//Checa se a tem água se não tiver a sprite volta a ficar nula
	}

	void OnMouseDown() //Se clicar na planta, sprite muda (botei uma sprite null)
	{
		Debug.Log ("clicou na plantinha");
		if (GameMaster.currentTool == "Pa") // com a pá
		{
			//Destroy (gameObject);
			GetComponent<SpriteRenderer>().sprite = semPlantaObj;
		}
			
		if ((GameMaster.currentTool == "Sementinha") && (GetComponent<SpriteRenderer>().sprite == semPlantaObj)) // com a semente e com a sprite null
		{
			
			GetComponent<SpriteRenderer>().sprite = florBrotinho;
		}

		if ((GameMaster.currentTool == "Regador") && (GetComponent<SpriteRenderer>().sprite == florBrotinho))// com a regador muda a cor pra ciano
		{
			
			lote.GetComponent<SpriteRenderer>().color = new Color (0, 1, 1, 1);
			//lote.GetComponent<SpriteRenderer>().sprite = terraComAgua;
			comAgua = true; //com agua o brotinho cresce
		}
	}
}
