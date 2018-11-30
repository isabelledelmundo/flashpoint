using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreateGameScript : MonoBehaviour
{

	//main menu buttons
	public Button familyButton;
	public Button experiencedButton;

	//scenes / Objects
	//public string createdFamilyLobby;
	//public string createdExpLobby;
	public GameObject familyForm;
	public GameObject experiencedForm;


	public void Awake()
	{
		//create for all functions w corresponding button
		familyButton.onClick.AddListener(LoadFamilyForm);
		experiencedButton.onClick.AddListener(LoadExpForm);


	}
	
	public void LoadFamilyForm()
	{
		Debug.Log("loading fam form");
		familyForm.SetActive(true);
	}

	public void LoadExpForm()
	{
		Debug.Log("loading exp form");
		experiencedForm.SetActive(true);
	}

}
