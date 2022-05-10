using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
	
	private void Start()
	{
		Time.timeScale = 0;
		this.newButton.onClick.AddListener(new UnityAction(this.newGame));

		this.resumeButton.onClick.AddListener(new UnityAction(this.resumeGame));
	}


	private void newGame()
	{  
		Debug.Log("---------new game-------------");
	

		SceneManager.LoadScene(1);
	}

	
	private void resumeGame()
	{
		if (PlayerPrefs.GetInt("level") != 0)
		{
			SceneManager.LoadScene(PlayerPrefs.GetInt("level"));
			return;
		}

		SceneManager.LoadScene(1);
	}

	[SerializeField]
	private Button newButton;

	[SerializeField]
	private Button resumeButton;
}
