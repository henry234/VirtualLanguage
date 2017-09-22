using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Product : MonoBehaviour
{
    public int code;
    public int sale;
    public int promotion_code;
    public float price;
    public string name;
    public string description;
    public string quotes;
    public string madein;
    public string useful;

    public void requestSpeech(int choose)
    {
        string text = "";

        switch (choose)
        {
            case 0:
			text = "The "+name+" costs "+ Price+" dollars and is "+" made in "+ Madein;
                break;
            case 1:
                text =""+ Price;
                break;
            case 2:
                text = "" + Description;
                break;
            case 3:
                 text = "" + Quotes;
                break;
            case 4:
                text = "" + Madein;
                break;
            case 5:
                text = "" + useful;
                break;
            default:
                break;
        }

		SpeechSpeaker.requestSpeech(text, this.transform);
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

    public string Description
    {
        get
        {
            return description;
        }

        set
        {
            description = value;
        }
    }

    public string Quotes
    {
        get
        {
            return quotes;
        }

        set
        {
            quotes = value;
        }
    }

    public float Price
    {
        get
        {
            return price;
        }

        set
        {
            price = value;
        }
    }

    public int Sale
    {
        get
        {
            return sale;
        }

        set
        {
            sale = value;
        }
    }

    public int Promotion_code
    {
        get
        {
            return promotion_code;
        }

        set
        {
            promotion_code = value;
        }
    }

    public int Code
    {
        get
        {
            return code;
        }

        set
        {
            code = value;
        }
    }

    public string Useful
    {
        get
        {
            return useful;
        }

        set
        {
            useful = value;
        }
    }

    public string Madein
    {
        get
        {
            return madein;
        }

        set
        {
            madein = value;
        }
    }
}
