using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

	private void Awake()
	{
		GameManager.instance = this;
	}


	private void Start()
	{
		this.leveltext.text = "Level:"+SceneManager.GetActiveScene().buildIndex.ToString();

	}


	private void Update()
	{
        this.scoretext.text = this.score.ToString();
		if (this.fill1.fillAmount == 1f && this.i == 0)
		{
			GameObject.FindObjectOfType<cameramove>().enabled = true;
			this.gameover();
			base.Invoke("LevelComplete", 3f);
			GameObject.Instantiate<GameObject>(this.particale, new Vector3(100f, 25f, 61f), Quaternion.Euler(23f, 29f, -4f));
			this.i = 1;
		}
	}


	public void LevelComplete()
	{
		this.levelcomplete.SetActive(true);
		this.ingame.SetActive(false);
	}


	public void LevelFail()
	{
		this.levelfail.SetActive(true);
		this.ingame.SetActive(false);
	}


	public void Resurrection()
	{
		GameObject.FindObjectOfType<PlayerInputManager>().enabled = true;
		GameObject.FindObjectOfType<PlayerInputManager>().transform.Find("Cube").gameObject.SetActive(true);
		GameObject.FindObjectOfType<PlayerInputManager>().transform.Find("Knife/Knife_Model").gameObject.SetActive(true);
		GameObject.FindObjectOfType<PlayerInputManager>().facturedknife.SetActive(false);
		this.levelfail.SetActive(false);
		this.ingame.SetActive(true);
	}


	public void RestartButton()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	
	public void NextButton()
	{
   	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	

	public void gameover()
	{
		GameObject.FindObjectOfType<PlayerInputManager>().enabled = false;
		GameObject.FindObjectOfType<PlayerInputManager>().GetComponent<Animator>().enabled = false;
		GameObject.FindObjectOfType<PlayerInputManager>().knife.rotation = Quaternion.Euler(0f, 0f, -45f);
	
	}

	
	public void Exit()
	{
	
		using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
		{
			using (AndroidJavaObject @static = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity"))
			{
				@static.Call("Exit", Array.Empty<object>());
			}
		}
	}
	

	public static GameManager instance;
    public GameObject levelcomplete;
    public GameObject levelfail;
    public GameObject ingame;
    public Text leveltext;
    public Text scoretext;
    public Text failtext;
	public Text wintext;
    public Image fill1;
    public int score;
    public GameObject particale;
    public float speed;
    private int i;
    private bool isShowAd;
}
