using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerNameAndAge : MonoBehaviour
{
    public Dictionary<string,int> footballPlayers = new Dictionary<string,int>();

    // Start is called before the first frame update
    void Start()
    {
        footballPlayers.Add("Ateet", 10);
        footballPlayers.Add("Sai", 50);
        footballPlayers.Add("Shuvam", 20);
        footballPlayers.Add("Venkat", 70);

        var footballPlayerAge = footballPlayers["Sai"];
        Debug.Log(footballPlayerAge);

        foreach (KeyValuePair<string,int> item in footballPlayers)
        {
            Debug.Log("Player age :" + item.Value);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
