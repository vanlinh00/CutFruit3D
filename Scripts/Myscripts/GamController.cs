using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamController : MonoBehaviour
{
    //  public ArrayList ListFruit = new ArrayList();
    public GameObject[] _listFruit = new GameObject[5];
    public GameObject[] _listInstanceGameSetUp = new GameObject[4];


    float checkPoz = 0f;
    void Start()
    {
     

        // wait for seconds
        //  StartCoroutine(ExampleCoroutine());

        base.InvokeRepeating("CreateOnePiece", 0.1f, 16.5f);


    }

    // Update is called once per frame
    void Update()
    {
        // checkPoz = _pflatForm2.transform.position.z;
        //   if (checkPoz == 80.86089f)
        //  {  
        /*
        if(_pflatForm1.active==true)
        {
            Destroy(_pflatForm1);
        }
        Destroy(_pflatForm2);
        */
   
          //  _pflatForm2 = CreateOnePiece(new Vector3(0f, 0f, 110f));

    //    }

    }
    void CreateLengtPiece(int countPicce)
    {
       for (int j=0;j< countPicce; j++)
        {
            GameObject _instanceGameSetup = Instantiate(Resources.Load("level/GameSetup", typeof(GameObject))) as GameObject;


            _listInstanceGameSetUp[j] = _instanceGameSetup;
         
            if(j>=1)
            {
                Vector3 newPosition = new Vector3(_listInstanceGameSetUp[j - 1].transform.position.x, _listInstanceGameSetUp[j - 1].transform.position.y, _listInstanceGameSetUp[j - 1].transform.position.z+110f);
                _listInstanceGameSetUp[j].transform.position = newPosition;
            }    

        

            for (int i = 0; i < _listInstanceGameSetUp[j].transform.childCount; i++)
            {
                if (_listInstanceGameSetUp[j].transform.GetChild(i).tag == "piece")
                {
                    GameObject createFruit = Instantiate(Resources.Load("Fruit/brenjal", typeof(GameObject))) as GameObject;
                    _listFruit[i] = createFruit;
                    _listFruit[i].transform.position = _listInstanceGameSetUp[j].transform.GetChild(i).transform.GetChild(0).transform.position;
                    _listFruit[i].transform.parent = _listInstanceGameSetUp[j].transform.GetChild(i);
                }
            }


       }    
    }

    GameObject CreateOnePiece()
    {
      //  Vector3 newRotation = new Vector3(0, 0, 0);
        GameObject _instanceGameSetup = Instantiate(Resources.Load("level/GameSetup", typeof(GameObject))) as GameObject;
    ;
        _instanceGameSetup.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        for (int i = 0; i < _instanceGameSetup.transform.childCount; i++)
        {
            if (_instanceGameSetup.transform.GetChild(i).tag == "piece")
            {
                GameObject createFruit = Instantiate(Resources.Load("Fruit/brenjal", typeof(GameObject))) as GameObject;
                _listFruit[i] = createFruit;
                _listFruit[i].transform.position = _instanceGameSetup.transform.GetChild(i).transform.GetChild(0).transform.position;
                _listFruit[i].transform.parent = _instanceGameSetup.transform.GetChild(i);
            }
        }
        return _instanceGameSetup;
    }
    IEnumerator ExampleCoroutine()
    {
      
            yield return new WaitForSeconds(17);
        
         
     }




    public void vehicledelay()
    {
        // t?o object  m?i
       // GameObject.Instantiate<GameObject>(this.floar, new Vector3(0f, 0f, 125f), Quaternion.identity);
    }


}
