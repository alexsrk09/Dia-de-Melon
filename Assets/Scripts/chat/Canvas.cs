using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
	[SerializeField] private Sprite emptySprite;
	[SerializeField] private GameObject imageLeft;
	[SerializeField] private GameObject imageRight;

	[Header("Melon")]
	[SerializeField] private Sprite characterFace1Normal;
	[SerializeField] private Sprite characterFace1Enfadado;
	[SerializeField] private Sprite characterFace1Sorpresa;
	[SerializeField] private Sprite characterFace1Triste;

	[Header("Melon Primo")]
	[SerializeField] private Sprite characterFace2Normal;
	[SerializeField] private Sprite characterFace2Enfadado;
	[SerializeField] private Sprite characterFace2Sorpresa;

	[Header("Melon Abuelo")]
	[SerializeField] private Sprite characterFace3Normal;
	[SerializeField] private Sprite characterFace3Enfadado;
	[SerializeField] private Sprite characterFace3Sorpresa;
	[SerializeField] private Sprite characterFace3Triste;

	[Header ("Sombra Padre")]
	[SerializeField] private Sprite characterFace4Normal;

	void Start(){
		
	}

	public void UpdateCanvas(int idCharacterLeft, int idFaceLeft, int idCharacterRight, int idFaceRight)
	{
		switch (idCharacterLeft)
		{
			case 1:
				imageRight.GetComponent<Image>().sprite = emptySprite;
				switch (idFaceLeft)
				{
					case 1:
						imageLeft.GetComponent<Image>().sprite = characterFace1Normal;
						break;
					case 2:
						imageLeft.GetComponent<Image>().sprite = characterFace1Sorpresa;
						break;
					case 3:
						imageLeft.GetComponent<Image>().sprite = characterFace1Enfadado;
						break;
					case 4:
						imageLeft.GetComponent<Image>().sprite = characterFace1Triste;
						break;
					default: 
						imageLeft.GetComponent<Image>().sprite = emptySprite;
						break;
				}
				break;
			case 2:
				imageRight.GetComponent<Image>().sprite = emptySprite;
				switch (idFaceLeft)
				{
					case 1:
						imageLeft.GetComponent<Image>().sprite = characterFace2Normal;
						break;
					case 2:
						imageLeft.GetComponent<Image>().sprite = characterFace2Sorpresa;
						break;
					case 3:
						imageLeft.GetComponent<Image>().sprite = characterFace2Enfadado;
						break;
					case 4:
						imageLeft.GetComponent<Image>().sprite = characterFace2Normal;
						break;
					default: 
						imageLeft.GetComponent<Image>().sprite = emptySprite;
						break;
				}
				break;
			case 3:
				imageRight.GetComponent<Image>().sprite = emptySprite;
				switch (idFaceLeft)
				{
					case 1:
						imageLeft.GetComponent<Image>().sprite = characterFace3Normal;
						break;
					case 2:
						imageLeft.GetComponent<Image>().sprite = characterFace3Sorpresa;
						break;
					case 3:
						imageLeft.GetComponent<Image>().sprite = characterFace3Enfadado;
						break;
					case 4:
						imageLeft.GetComponent<Image>().sprite = characterFace3Triste;
						break;
					default: 
						imageLeft.GetComponent<Image>().sprite = emptySprite;
						break;
				}
				break;
			case 4:
				imageRight.GetComponent<Image>().sprite = emptySprite;
				switch (idFaceLeft)
				{
					case 1:
						imageLeft.GetComponent<Image>().sprite = characterFace4Normal;
						break;
					default: 
						imageLeft.GetComponent<Image>().sprite = emptySprite;
						break;
				}
				break;
			default: 
				imageLeft.GetComponent<Image>().sprite = emptySprite;
				break;
		}

		switch (idCharacterRight)
		{
			case 1:
				imageLeft.GetComponent<Image>().sprite = emptySprite;
				switch (idFaceRight)
				{
					case 1:
						imageRight.GetComponent<Image>().sprite = characterFace1Normal;
						break;
					case 2:
						imageRight.GetComponent<Image>().sprite = characterFace1Sorpresa;
						break;
					case 3:
						imageRight.GetComponent<Image>().sprite = characterFace1Enfadado;
						break;
					case 4:
						imageRight.GetComponent<Image>().sprite = characterFace1Normal;
						break;
					default: 
						imageRight.GetComponent<Image>().sprite = emptySprite;
						break;
				}
				break;
			case 2:
				imageLeft.GetComponent<Image>().sprite = emptySprite;
				switch (idFaceRight)
				{
					case 1:
						imageRight.GetComponent<Image>().sprite = characterFace2Normal;
						break;
					case 2:
						imageRight.GetComponent<Image>().sprite = characterFace2Sorpresa;
						break;
					case 3:
						imageRight.GetComponent<Image>().sprite = characterFace2Enfadado;
						break;
					case 4:
						imageRight.GetComponent<Image>().sprite = characterFace2Normal;
						break;
					default: 
						imageRight.GetComponent<Image>().sprite = emptySprite;
						break;
				}
				break;
			case 3:
				imageLeft.GetComponent<Image>().sprite = emptySprite;
				switch (idFaceRight)
				{
					case 1:
						imageRight.GetComponent<Image>().sprite = characterFace3Normal;
						break;
					case 2:
						imageRight.GetComponent<Image>().sprite = characterFace3Sorpresa;
						break;
					case 3:
						imageRight.GetComponent<Image>().sprite = characterFace3Enfadado;
						break;
					case 4:
						imageRight.GetComponent<Image>().sprite = characterFace3Triste;
						break;
					default: 
						imageRight.GetComponent<Image>().sprite = emptySprite;
						break;
				}
				break;
			case 4:
				imageLeft.GetComponent<Image>().sprite = emptySprite;
				switch (idFaceRight)
				{
					case 1:
						imageRight.GetComponent<Image>().sprite = characterFace4Normal;
						break;
					default: 
						imageRight.GetComponent<Image>().sprite = emptySprite;
						break;
				}
				break;
			default: break;
		}
	}
	public void PrintChatMessage(string message)
	{
		// get the text component of the canvas
		Text text = GetComponentInChildren<Text>();
		// set the text of the canvas
		text.text = message;
	}
}
