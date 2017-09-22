using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashierDialog : MonoBehaviour {

	//public GameObject par;

	public Image cashierDialog;
	public Text _text;

	// Use this for initialization
	void Start () {
		cashierDialog.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setText(string text){
		cashierDialog.enabled = true;
		_text.text = text;

	}

	public void setPosition(Transform trans){
		this.transform.position = trans.position;

	}
	public void setVisible(string text, Transform trans){
		setText (text);
		setPosition (trans);
	}

}
