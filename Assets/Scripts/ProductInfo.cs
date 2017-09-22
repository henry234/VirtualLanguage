using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductInfo : MonoBehaviour {

    public static List<ProductInfo> pro_info = new List<ProductInfo>();
  
    private int[] code = {101,102,103,104 };
    private int[] sale = { 10,23,30,50};
    private int[] promotion_code = {0,0,0,0 };
    private float[] price = {0.6f,0.3f,0.5f,2.5f };
    private string[] name = {"Apple","Banana","Tomato","Soap" };
    private string[] description = {
        "It is a great fruit to stay healthy and has many vitamins.",
        "Bananas are often used to make smoothies and milkshakes. They are known for being sweet",
        "Tomatos are fruits. since the grow from the plant blossoms and carry the seeds of the plant",
        "Soap can come in many forms. This is liquid soap" };
    private string[] quotes = {
        "An apple a day keeps the doctor away",
        "I go bananas over chocolate",
       "You are as red as a tomato.",
       "I wish to wash my sons mouth with soap sometimes." };
    private string[] madein = {
        "Turkey and many western countries",
        "Asian and South American countries",
        "Germany",
        "US" };
    private string[] userful = {
        "Since it is considered a healthy fruit and also hard which indicates, if you have strong teeth and healthy teeth. ",
        "This is a saying when somebody likes something/someone so much to get crazy. I go bananas over ice-cream.",
        "When people have a sunburn or turn red.",
        "When people have a bad way of talking one says this. Meaning to make their words cleaner" };

    //Need database to import from excel file or somthing
    void Start () {
        for (int i = 0; i < code.Length; i++)
        {
            Product pro = new Product();
            pro.Code = code[i];
            pro.Sale = sale[i];
            pro.Promotion_code = promotion_code[i];
            pro.Price = price[i];
            pro.Name = name[i];
            pro.Description = description[i];
            pro.Quotes = quotes[i];
            pro.Useful = userful[i];
        }
		
	}
	
	
}
