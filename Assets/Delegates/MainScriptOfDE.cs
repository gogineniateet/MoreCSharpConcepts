using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScriptOfDE : MonoBehaviour
{
    public delegate void ActionClick();
    public static event ActionClick onActionClick;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onActionClick();
        }

    }
}
