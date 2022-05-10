using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCubeColor : MonoBehaviour
{
    public delegate void ActionButtonClick();
    public static event ActionButtonClick onActionButtonClick;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CubeColorChange()
    {
        if (onActionButtonClick != null)
        {
            onActionButtonClick();
        }
    }
}
