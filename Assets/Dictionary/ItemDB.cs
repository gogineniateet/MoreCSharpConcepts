using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> itemList = new List<Item>();
    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();   


    // Start is called before the first frame update
    void Start()
    {
        Item MyKnife = new Item();
        MyKnife.Name = "knife";
        MyKnife.id = 0;

        Item MyBullet = new Item();
        MyBullet.Name = "Bullet";
        MyBullet.id = 1;

        Item MyCar = new Item();
        MyCar.Name = "Car";
        MyCar.id = 2;

        itemDictionary.Add(0, MyKnife);
        itemDictionary.Add(1, MyBullet);
        itemDictionary.Add(2, MyCar);
        //foreach (KeyValuePair<int,Item> item in itemDictionary)
        //{
        //    Debug.Log("Key :" + item.Key);
        //    //Debug.Log("Value :" +item.Value.Name);
        //}
        //foreach (Item item in itemDictionary.Values)
        //{
        //    Debug.Log("values :" + item.Name);
        //}

        itemList.Add(MyKnife);
        itemList.Add(MyBullet);
        itemList.Add(MyCar);

        //foreach (var item in itemList)
        //{
        //    Debug.Log(item.Name);
        //    Debug.Log(item.id);
        //}

        var myDictionaryItem =  itemDictionary[1];
        Debug.Log(myDictionaryItem.Name);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
