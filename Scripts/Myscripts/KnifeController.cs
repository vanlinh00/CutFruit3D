using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="cucu")
        {
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }    
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
}