using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class entrega_4 : MonoBehaviour
{

    //ejercicio 1
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

    //ejercicio 2

    [SerializeField] private bool a;
    [SerializeField] private bool e;
    [SerializeField] private bool i;
    [SerializeField] private bool o;
    [SerializeField] private bool u;

    //ejercicios 3
    [SerializeField] private int dias;
    [SerializeField] private int mes;
    [SerializeField] private int año;


    [SerializeField] private bool A;
    [SerializeField] private bool B;
    [SerializeField] private bool C;
    [SerializeField] private bool D;


    [SerializeField] private float numm1;
   

     
    void Start()
    {

        //ejercicio 1
        float lowest = FindLowest(num1, num2);
        Debug.Log("el numero mas bajo es: " + lowest);


        OnBecameVisible();

        ValidDate();

        chainiseyear();

        notas();

        parinpar();
    }


    //ejercicio 2

    private void OnBecameVisible()
    {
        if (a)
        {
            Debug.Log(message: "es una vocal");
        }
        else if (e)
        {
            Debug.Log(message: "es una vocal");

        }
        else if (i)
        {
            Debug.Log(message: "es una vocal");

        }
        else if (o)
        {
            Debug.Log(message: "es una vocal");

        }
        else if (u)
        {
            Debug.Log(message: "es una vocal");

        }
        else
        {
            Debug.Log(message: "es una CONSONANTE");

        }
    }



    //ejercicio 3
    private void ValidDate()
    {
        if (mes == 1)
        {
            if (dias >= 1 && dias < 32)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 2)
        {
            if (dias >= 1 && dias < 29)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }

        }
        else if (mes == 3)
        {
            if (dias >= 1 && dias < 32)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 4)
        {
            if (dias >= 1 && dias < 31)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 5)
        {
            if (dias >= 1 && dias < 32)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 6)
        {
            if (dias >= 1 && dias < 31)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 7)
        {
            if (dias >= 1 && dias < 32)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 8)
        {
            if (dias >= 1 && dias < 32)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 9)
        {
            if (dias >= 1 && dias < 31)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 10)
        {
            if (dias >= 1 && dias < 32)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 11)
        {
            if (dias >= 1 && dias < 31)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 12)
        {
            if (dias >= 1 && dias < 32)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
    }



    // ejercicio 4




    //ejercicio 5



    // ejercicio 6




    //ejercicio 7     
    private void chainiseyear()
    {
        if (año % 12 == 0)
        {
            Debug.Log(message: "es el año del mono");
        }
        else if (año % 12 == 1)
        {
            Debug.Log(message: "es el año del gallo");
        }
        else if (año % 12 == 2)
        {
            Debug.Log(message: "es el año del perro");
        }
        else if (año % 12 == 3)
        {
            Debug.Log(message: "es el año del cerdo");
        }
        else if (año % 12 == 4)
        {
            Debug.Log(message: "es el año del rata");
        }
        else if (año % 12 == 5)
        {
            Debug.Log(message: "es el año del buey");
        }
        else if (año % 12 == 6)
        {
            Debug.Log(message: "es el año del tigre");
        }
        else if (año % 12 == 7)
        {
            Debug.Log(message: "es el año del conejo");
        }
        else if (año % 12 == 8)
        {
            Debug.Log(message: "es el año del dragon");
        }
        else if (año % 12 == 9)
        {
            Debug.Log(message: "es el año del serpiente");
        }
        else if (año % 12 == 10)
        {
            Debug.Log(message: "es el año del caballo");
        }
        else if (año % 12 == 11)
        {
            Debug.Log(message: "es el año del cabra");
        }
        else if (año % 12 == 12)
        {
            Debug.Log(message: "es el año del mono");
        }
        else
        {
            Debug.Log(message: "no es el año de nada esta mal");

        }
    }

    //ejercicio 8




    //ejercicio 9
    private void notas()
    {
        if (A)
        {
            Debug.Log(message: "excelente");
        }
        else if (B)
        {
            Debug.Log(message: "notable");
        }
        else if (C)
        {
            Debug.Log(message: "aprobado");
        }
        else if (D)
        {
            Debug.Log(message: "suspenso");
        }
    }


    //ejercicio 10
    private void parinpar()
    {
        if(numm1 % 2 == 0)
        {
            Debug.Log("es par");
        }
        else
        {
            Debug.Log("es inpar");

        }
    }
















}
