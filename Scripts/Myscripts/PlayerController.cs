using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject KnifeFractured;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            base.GetComponent<Animator>().enabled = true;
        }    
        if(Input.GetMouseButtonUp(0))
        {
            
            base.GetComponent<Animator>().enabled = false;
            base.GetComponent<Transform>().rotation = Quaternion.Euler(0f, 0f, -45f);
        }    
        
    }
    
}
