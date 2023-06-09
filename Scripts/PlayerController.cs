using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*public float speed = 10.0f;
    public float turnSpeed = 0.0f;
    public float horizontalInput;
    public float forwardInput;*/

    private float speed = 10.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal"); //the axis name is the same in the InputManager
        forwardInput = Input.GetAxis("Vertical"); //the axis name is the same in the InputManager


        //transform.Translate(0, 0, 1);
        //transform.Translate(Vector3.forward);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }
}
