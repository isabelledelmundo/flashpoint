using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	//main menu buttons
	public Button createGameButton;
	public Button loadGameButton;
	public Button joinGameButton;
	public Button backButton;
	public Button exitGameButton;

	

	//scenes
	public string createGameSceneName;
	public GameObject activeGamesList;
	public GameObject saveGamesList;


	public void Awake() {
		//create for all functions w corresponding button
		createGameButton.onClick.AddListener(CreateGame);
		loadGameButton.onClick.AddListener(LoadSaveFiles);
		joinGameButton.onClick.AddListener(OpenActiveGamesList);
		backButton.onClick.AddListener(CloseActiveGamesList);
		exitGameButton.onClick.AddListener(ExitGame);

	}
	public void CreateGame(){
		SceneManager.LoadScene(createGameSceneName);

	}

	public void LoadSaveFiles(){
		saveGamesList.SetActive(true);
	}

	public void OpenActiveGamesList(){
		activeGamesList.SetActive(true);
	}
	public void CloseActiveGamesList(){
		activeGamesList.SetActive(false);
	}


	public void ExitGame(){
		Debug.Log("trying to exit game");
		Application.Quit();
	}


}
