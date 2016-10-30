using UnityEngine;
using System.Collections;

public class Spawnear : MonoBehaviour {


	
	// Update is called once per frame
	void Update ()
    {
        ObjectPool activate = GameObject.Find("ObjectPool").GetComponent<ObjectPool>();
        if (Input.GetKeyDown(KeyCode.Space)) activate.ActivateObject();
        if (Input.GetKeyDown(KeyCode.R)) activate.DeactivateObject();
	
	}
}
