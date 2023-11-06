using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eliceRotation : MonoBehaviour
{
    [SerializeField] private float speed = 400.0f;

    private float frontalInput;


    // Update is called once per frame
    void Update()
    {
        frontalInput =Input.GetAxis("Vertical");

        transform.Rotate(Vector3.forward, speed * Time.deltaTime);



    }
}
