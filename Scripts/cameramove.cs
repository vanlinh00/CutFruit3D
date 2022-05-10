using System;
using UnityEngine;


public class cameramove : MonoBehaviour
{

	public void Update()
	{
	   this.MainCamera.transform.position = Vector3.Lerp(base.transform.position, this.TargetPosition.transform.position, (float)this.speed * Time.deltaTime);
	 	this.MainCamera.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.TargetPosition.transform.rotation, (float)this.speed * Time.deltaTime);
	}


	public Camera MainCamera;


	public GameObject TargetPosition;


	public int speed = 2;

	private bool camera_move_enabled;
}
