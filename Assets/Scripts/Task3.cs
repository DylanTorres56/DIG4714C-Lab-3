using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    //    You are supposed to be paid $X dollars.How many bills of
    //hundred, fifty, twenty, ten, five, or one will you get? (For example,
    //if you are to be paid $47, you will get 2 x $20 bills, 1 x $5 bill, and
    //2 x $1 bills.)
    //I want to enter an X value, and the program should produce a
    //meaningful output that gives me how that amount should be paid
    //in bills. (Assume/control that the amount will not have
    //decimals—so, no change coins.Actually, makesure of it...)

    [SerializeField]
    int x;
    //each bill is a seperate int
    int hundreds, fiftys,twentys ,tens, fives,ones;
    // Start is called before the first frame update
    void Start()
    {
        CalculateBills(x);
        //print the values of the bills
        Debug.LogFormat("Hundreds: {0}| Fiftys: {1}| Twenties: {2}| Tens: {3}| Fives: {4}| Ones: {5}",hundreds,fiftys,twentys,tens,fives,ones);
    }

    //method that calculates the number of bills in line using division and modulo
    void CalculateBills(int amount)
    {
        
        int remainder=amount;
        if (remainder >= 100)
        {
            hundreds= remainder / 100;
            remainder= remainder % 100;
        }
        if(remainder >= 50)
        {
            fiftys = remainder / 50;
            remainder = remainder % 50;
        }
        if (remainder >= 20)
        {
            twentys = remainder / 20;
            remainder = remainder % 20;
        }
        if (remainder >= 10)
        {
            tens = remainder / 10;
            remainder = remainder % 10;
        }
        if(remainder >= 5)
        {
            fives = remainder / 5;
            remainder = remainder % 5;
        }
        if(remainder>=1)
        {
            ones = remainder;
          
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
