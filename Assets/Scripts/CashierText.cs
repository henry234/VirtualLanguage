using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashierText : MonoBehaviour {
	public Text cashierDialogText;
	// Use this for initialization
	void Start () {
		cashierDialogText.text = "hi";
		cashierDialogText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void WhiteColor() {
		cashierDialogText.text = "Hello";
		cashierDialogText.enabled = true;
	}

	public void RedColor() {
		cashierDialogText.text = "out";
		cashierDialogText.enabled = false;
	}
}
