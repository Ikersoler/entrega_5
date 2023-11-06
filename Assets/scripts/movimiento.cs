using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{

    [SerializeField] private float speed = 20.0f;
    [SerializeField] private float UpDownspeed = 30.0f;
    [SerializeField] private GameObject camara;
    private Vector3 camaraOffset = new Vector3(9, 1.73f, 0);

    private float verticalInput;
    private float horizontalInput;
    private float rotationInput;


    void Update()
    {

        verticalInput =Input.GetAxis("Vertical");
        horizontalInput =Input.GetAxis("Horizontal");


        transform.Rotate(Vector3.left, UpDownspeed * Time.deltaTime * verticalInput);

        transform.Translate(translation: Vector3.forward * speed * Time.deltaTime * horizontalInput);

       camara.transform.position = transform.position + camaraOffset;

    }
}
