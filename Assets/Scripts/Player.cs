using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private string name1;
    private float money;
    private int age;
    public static bool requestSpeech = false;
    public static bool acceptSpeech = false;
    private Bag myBag;
    public GameObject pallet;
   
    void Start()
    {
        myBag = new Bag();
      
       
    }
    void Update()
    {

    }
    void buyAnItem(GameObject it)
    {

        iTween.MoveTo(it, pallet.transform.position, 2f);
    }
    public void buyAnProduct()
    {

    }
    public string Name
    {
        get
        {
            return name1;
        }

        set
        {
            name1 = value;
        }
    }

    public float Money
    {
        get
        {
            return money;
        }

        set
        {
            money = value;
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
