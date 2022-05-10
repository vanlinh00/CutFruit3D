using System;
using UnityEngine;


public class GameController : MonoBehaviour
{
	private void Start()
	{
		this.rb = base.GetComponent<Rigidbody>();
		this.lastTime = PlayerPrefs.GetFloat("LastTime");
		
	}

	private void Update()
	{
	}


	public void OnCollisionEnter(Collision other)
	{
		Debug.Log(other.gameObject.tag + other.gameObject.name);
		if (other.gameObject.tag == "cucu")
		{
		//	GameObject.FindObjectOfType<GameManager>().score++;
		//	GameObject.FindObjectOfType<GameManager>().fill1.fillAmount = (float)GameObject.FindObjectOfType<GameManager>().score / this.totalscore;
	//	other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
	//	   this.rb.AddForce(0f, 0f, -0.5f);
		//	GameObject.Instantiate<GameObject>(this.cucuparticale, base.transform.position, base.transform.rotation);
		}
		if (other.gameObject.tag == "tamoto")
		{
			GameObject.FindObjectOfType<GameManager>().score++;
			other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
			GameObject.Instantiate<GameObject>(this.tamatoparticale, base.transform.position, base.transform.rotation);
		}
		if (other.gameObject.tag == "brizal")
		{
			GameObject.FindObjectOfType<GameManager>().score++;
			other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
			GameObject.Instantiate<GameObject>(this.brizalparticale, base.transform.position, base.transform.rotation);
		}
		if (other.gameObject.tag == "mashroom")
		{
			GameObject.FindObjectOfType<GameManager>().score++;
			other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
			GameObject.Instantiate<GameObject>(this.mashroomparticale, base.transform.position, base.transform.rotation);
		}
		if (other.gameObject.tag == "bomb")
		{
			GameObject.Destroy(other.gameObject);
			GameObject.Instantiate<GameObject>(this.bombparticale, base.transform.position, base.transform.rotation);
		}
	}


	public GameObject cucuparticale;


	public GameObject tamatoparticale;


	public GameObject brizalparticale;


	public GameObject mashroomparticale;


	public GameObject bombparticale;


	public Rigidbody rb;


	public float totalscore;


	public float lastTime;

  public bool isShowBoard;
}
