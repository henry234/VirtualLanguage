using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour {
    private List<Product> listItem;
    private float total=0;
	void Start () {
        listItem = new List<Product>();
	}
	
	public void addProToBag(Product pro)
    {
        total += pro.Price;
        listItem.Add(pro);
    }
    public int numberItem()
    {
        return listItem.Count;
    }
    public float totalMoney()
    {
        return total;
    }
}
