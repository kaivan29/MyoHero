using UnityEngine;
using System.Collections;
using System;

public class TranslationD : MonoBehaviour {


    bool readyForKeyPress = false;
    static System.Random rand = new System.Random();


	// Update is called once per frame
	void Update () {

				transform.Translate (new Vector3 (-30,0,0)*Time.deltaTime);
        //public void Rotate(Vector3 eulerAngles, Space relativeTo = Space.Self); 
        //15, 45 and 30 are euler angles
        //we are going to keep space default here.

        if (readyForKeyPress && Input.GetKeyDown("d"))
        {
            transform.Translate(new Vector3(rand.Next(350, 450), 0, 0));
            readyForKeyPress = false;
        }

    }
    //A prefab is an asset that contains a template

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Cube"))
        {
            readyForKeyPress = true;
        }
        if (other.gameObject.CompareTag("End"))
        {
            transform.Translate(new Vector3(rand.Next(400, 500), 0, 0));
            readyForKeyPress = false;
        }

    }

}
