using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashierSpeech  {
    private int type; //0 question 1 answer 2 im 
    private int entity; 
    private string intent;

    public int Entity
    {
        get
        {
            return entity;
        }

        set
        {
            entity = value;
        }
    }
}
