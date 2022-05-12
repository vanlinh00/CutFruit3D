using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    
    // Start is called before the first frame update
    public float Speed=-5.0f;
    void Start()
    {
   

       
    }

    // Update is called once per frame
    void Update()
    {
        base.transform.Translate(0f,0f,this.Speed * Time.deltaTime);
    }
}
