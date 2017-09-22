using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cashier : MonoBehaviour {
    private string name;
    private string gender;
    private int age;
    public static float totalMoneyCustomer =0;
	public GameObject cashierDialog;
    public static string[] speak = {
        "Good morning, Sir!",
        "Have fun shopping today.",
        "Let me scan your items. ",
        "Your total is.",
        "How are you?",
         "Thank for shoopping at Super Market",
    };
    void Start()
    {
      
    }
    public void requestSpeech(int choose)
    {
        string text = speak[choose];
        if (choose == 3)
        {
            text = text + " " + totalMoneyCustomer + " " + DialogText.CURRENTCY;
        }
        
		SpeechSpeaker.requestSpeech(speak[choose], this.transform);


		//cashierDialog.transform.position = this.transform.position;

    }


    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    public string Gender
    {
        get
        {
            return gender;
        }

        set
        {
            gender = value;
        }
    }

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            age = value;
        }
    }

    
}
