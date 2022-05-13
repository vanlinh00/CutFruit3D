using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierController : MonoBehaviour
{
    // Start is called before the first frame update
  
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("dao vao player");
       
            GameObject KnifeFractured = Instantiate(Resources.Load("Knife/KnifeFractured", typeof(GameObject))) as GameObject;
            KnifeFractured.transform.position = new Vector3(1, 4.19f, 14.8000002f);
            other.gameObject.active = false;
            for (int i = 0; i < KnifeFractured.transform.childCount; i++)

            {
                if (KnifeFractured.transform.GetChild(i).GetComponent<Rigidbody>())
                {
                    KnifeFractured.transform.GetChild(i).GetComponent<Rigidbody>().isKinematic = false;
                }

            }
        }
    }
   
   
      
   
}
