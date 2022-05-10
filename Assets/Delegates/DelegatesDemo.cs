using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegatesDemo : MonoBehaviour
{
    // Start is called before the first frame update
    public delegate void ChangeColor(Color newColor); // Delegate should not be null
    public ChangeColor onChangeColor;
    public delegate void OnComplete();
    public OnComplete onChangeComplete;
    void Start()
    {
        onChangeColor = UpdateColor;
        onChangeColor(Color.red);
        onChangeComplete += TaskCompleted;
        onChangeComplete += TaskTwoCompleted;
        onChangeComplete += TaskThreeCompleted;
        onChangeComplete -= TaskThreeCompleted;
        if (onChangeComplete != null)
        {
            onChangeComplete();
        }
    }

    private void TaskCompleted()
    {
        Debug.Log("Task Completed");
    }
    private void UpdateColor(Color newColor)
    {
        Debug.Log("Changing the color to:" + newColor.ToString());
    }
    private void TaskTwoCompleted()
    {
        Debug.Log("Task two Completed");
    }
    private void TaskThreeCompleted()
    {
        Debug.Log("Task three Completed");
    }
    // Update is called once per frame
    void Update()
    {

    }

}
