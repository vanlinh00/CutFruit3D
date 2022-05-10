using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GiftManager : MonoBehaviour
{
	

	private void Awake()
	{
	}

	
	private void Start()
	{
	
	}

	
	public void ShowResurrectionBoard()
	{
		this.ResurrectionBoard.SetActive(true);
	}


	public void ShowAllGameBoard()
	{
	}

	public void BuySuccess(string index)
	{
	}

	
	public void BuyFail(string index)
	{
	}

	
	public void BuyVip()
	{
	}

	
	public void BuyGame()
	{
		
	}

	
	public void BuyResurrection()
	{
		
	}


	public static GiftManager Instance;

	
	public GameObject ResurrectionBoard;


	public GameObject AllGameBoard;

	
	public GameObject VipButton;


	public GameObject VipButton2;

	
	public bool isBuyGame;


	public bool isNoDie;
	
}
