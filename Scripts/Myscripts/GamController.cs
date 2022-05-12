using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamController : MonoBehaviour
{
    //  public ArrayList ListFruit = new ArrayList();
    public GameObject[] _listFruit = new GameObject[5];
    public GameObject[] _listInstanceGameSetUp = new GameObject[4];
    void Start()
    {
        //    CreateLengtPiece(3);

        GameObject _instanceGameSetup = Instantiate(Resources.Load("level/GameSetup", typeof(GameObject))) as GameObject;

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

       // -47.59


    }

    // Update is called once per frame
    void Update()
    {
        
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
}
