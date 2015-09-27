using UnityEngine;
using System.Collections;
using System;

public class Translation : MonoBehaviour {
	
	int i = 0;
	// Update is called once per frame
	void Update () {
		while(i<100)
		{
				transform.Translate (new Vector3 (0,0,2)*Time.deltaTime);
		//public void Rotate(Vector3 eulerAngles, Space relativeTo = Space.Self); 
		//15, 45 and 30 are euler angles
		//we are going to keep space default here.
         		i = i+1;
		}
	}
	//A prefab is an asset that contains a template

}
