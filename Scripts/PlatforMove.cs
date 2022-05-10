using System;
using UnityEngine;


public class PlatforMove : MonoBehaviour
{
	
	private void Start()
	{
		base.InvokeRepeating("vehicledelay", 0.1f, 16.5f);
	}


	public void vehicledelay()
	{
		GameObject.Instantiate<GameObject>(this.floar, new Vector3(0f, 0f, 125f), Quaternion.identity);
	}


	public Transform startpostion;


	public GameObject floar;
}
