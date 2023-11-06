using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entrega_4 : MonoBehaviour
{
    [SerializeField] private float num1 = 5.3f;
    [SerializeField] private float num2 = 3.7f;


    [SerializeField]private float FindLowest(float number1, float number2)
    {
        if (number1 < number2)
        {
            return number1;
        }
        else
        {
            return number2;
        }
    }



    void Start()
    {

        float lowest = FindLowest(num1, num2);
        Debug.Log("The lowest number is: " + lowest);

    }

    









    void Update()
    {
        
    }









}
