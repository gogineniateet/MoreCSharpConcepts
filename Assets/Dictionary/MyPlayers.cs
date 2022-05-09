using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayers : MonoBehaviour
{
    public Dictionary<int, Player> playersDictionary = new Dictionary<int, Player>();

    // Start is called before the first frame update
    void Start()
    {
        Player playerOne = new Player(1);
        playerOne.name = "Ateet";
        Player playerTwo = new Player(20);
        playerTwo.name = "Venkat";        
        Player playerThree = new Player(13);
        playerThree.name = "Shuvam";

        playersDictionary.Add(playerOne.id, playerOne);
        playersDictionary.Add(playerTwo.id, playerTwo);
        playersDictionary.Add(playerThree.id, playerThree);

        var myDictionary = playersDictionary[playerTwo.id];
        Debug.Log("Player name : " + myDictionary.name);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var myDictionary = playersDictionary[13];
            Debug.Log("Player name : " + myDictionary.name);
        }
    }
}
