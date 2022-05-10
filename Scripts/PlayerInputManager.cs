using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerInputManager : MonoBehaviour
{
	
	private void Start()
	{
		Time.timeScale = 1;
	}

	
	private void Update()
	{

		

		if (Input.GetMouseButtonDown(0))
		{
			base.GetComponent<Animator>().enabled = true;
		}
		if (Input.GetMouseButtonUp(0))
		{
			base.GetComponent<Animator>().enabled = false;
			this.knife.rotation = Quaternion.Euler(0f, 0f, -45f);
		}
	}

	
	public bool mouseCliked;

	public float speed;

	
	public Transform knife;

	
	public GameObject knfe;

	
	public GameObject facturedknife;
}
