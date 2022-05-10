using System;
using UnityEngine;

// Token: 0x02000005 RID: 5
public class BrakeKnife : MonoBehaviour
{
	// Token: 0x0600000A RID: 10 RVA: 0x0000216D File Offset: 0x0000036D
	private void Awake()
	{
		this.fracterdknife = GameObject.FindObjectOfType<PlayerInputManager>().facturedknife;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002180 File Offset: 0x00000380
	public void OnTriggerEnter(Collider collision)
	{
		
		if (collision.gameObject.tag == "Player")
		{
			//Time.timeScale = 0;


			   
			collision.gameObject.SetActive(false);

			this.fracterdknife.SetActive(true);

				for (int i = 0; i < this.fracterdknife.transform.childCount; i++)
				{
					if (this.fracterdknife.transform.GetChild(i).GetComponent<Rigidbody>())
					{
						this.fracterdknife.transform.GetChild(i).GetComponent<Rigidbody>().isKinematic = false;
					}
				}
				/*
				if (GiftManager.Instance.isNoDie)
				{
					return;
				}
				*/
			//	Debug.Log("sd");
					base.Invoke("levelfailui", 2f);
				//	base.Invoke("ShowBoard", 2f);
		
			//levelfailui();
		}
	}

	// Token: 0x0600000C RID: 12 RVA: 0x0000224A File Offset: 0x0000044A
	public void levelfailui()
	{
		GameObject.FindObjectOfType<GameManager>().LevelFail();
		GameObject.FindObjectOfType<GameManager>().gameover();
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002260 File Offset: 0x00000460
	public void ShowBoard()
	{
	//	GiftManager.Instance.ShowResurrectionBoard();
	}

	// Token: 0x04000003 RID: 3
	public GameObject fracterdknife;
}
