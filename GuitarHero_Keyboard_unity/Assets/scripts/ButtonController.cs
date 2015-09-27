using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {
	
	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("KeyNote"))
			other.gameObject.SetActive (false);
	}
}
