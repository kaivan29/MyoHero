using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {
	
	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
}
