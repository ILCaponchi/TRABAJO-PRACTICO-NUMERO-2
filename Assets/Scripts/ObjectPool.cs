using UnityEngine;
using System.Collections;

public class ObjectPool : MonoBehaviour {

    private GameObject[] objects = null;
    public GameObject objectToInstantiate;
    public int poolSize = 0;

	// Use this for initialization
	void Start ()
    {
        objects = new GameObject[poolSize];
        for(int i=0; i< poolSize; i++)
        {
            objects[i] = Instantiate(objectToInstantiate) as GameObject;
            objects[i].transform.parent = gameObject.transform;
            objects[i].SetActive(false);

        }
	
	}

    public void ActivateObject()
    {
        for(int i =0; i < poolSize; i++)
        {
            if(objects[i].activeInHierarchy == false)
            {
                objects[i].SetActive(true);
                return;

            }

        }


    }

    public void DeactivateObject()
    {
        for(int i = 0; i < poolSize; i++)
        {

            if(objects[i].activeInHierarchy == true)
            {
                objects[i].SetActive(false);

            }
        }

    }
	

}
