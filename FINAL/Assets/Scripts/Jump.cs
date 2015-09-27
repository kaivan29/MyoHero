using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

    double angle = 0;
	
	// Update is called once per frame
	void Update () {

        sinPosition();
	
	}

    void sinPosition()
    {
        angle += 10;
        double yOffset = 110;
        double newY = yOffset + 5 * Mathf.Sin((float)(Mathf.PI * angle / 360));
        Vector3 currentPos = transform.position;
        transform.position = new Vector3(currentPos.x, (float)newY, currentPos.z);
    }
}
