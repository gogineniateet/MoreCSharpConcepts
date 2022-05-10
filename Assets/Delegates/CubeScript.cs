using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{ // Start is called before the first frame update

    void Start()
    {
        ChangeCubeColor.onActionButtonClick += ToTurnRed;
        // ChangeCubeColorUsingDE.onActionButtonClick -= 

    }
    public void ToTurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    public void ToTurnBlue()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
    public void OnDisable()
    {
        Debug.Log("In Disable method");
        ChangeCubeColor.onActionButtonClick += ToTurnBlue;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
