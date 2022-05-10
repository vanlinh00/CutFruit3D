using System;
using UnityEngine;


public class platform : MonoBehaviour
{
	private void Start()
	{
	
	}

	private void Update()
	{
		this.speed = 9f;
		
		base.transform.Translate(0f, 0f, -this.speed * Time.deltaTime);
	}
	public void setSpeed(float a)
    {
	    speed =a;
		
    }		
	
	// Token: 0x04000026 RID: 38
	public float speed;
	public float Fspeed;
}
