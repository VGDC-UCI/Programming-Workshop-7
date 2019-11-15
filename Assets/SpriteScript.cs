using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScript : MonoBehaviour {

	Animator myController;
	[SerializeField] AudioSource audio1;
	[SerializeField] AudioSource audio2;

	// Use this for initialization
	void Start () {
		myController = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")) {
			myController.SetTrigger("doCircle");
		}
		if (Input.GetAxisRaw("Horizontal") > 0 && audio1.isPlaying == false) {
			audio1.Play();
		}
		if (Input.GetAxisRaw("Horizontal") < 0 && audio2.isPlaying == false) {
			audio2.Play();
		}
	}
}
