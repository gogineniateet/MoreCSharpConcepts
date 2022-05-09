using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PartTimeEmployee : Employee
{

    private void Start()
    {
        CalculateMonthlySalary();
    }
    public int hoursWorked;
    public int hourlyRate;
    public override void CalculateMonthlySalary()
    {
        Debug.Log(hourlyRate * hoursWorked);
    }

}