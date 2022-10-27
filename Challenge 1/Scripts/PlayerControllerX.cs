using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed=5;
    public float rotationSpeed=1;
    public float verticalInput;
    public float verticalInputAxis;
    public float horizontalInputAxis;
    public float leftrightInputAxis;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        verticalInputAxis = Input.GetAxis("Vertical");
        horizontalInputAxis = Input.GetAxis("Horizontal");
        leftrightInputAxis = Input.GetAxis("LR");
        transform.Translate(Vector3.forward * Time.deltaTime *speed*horizontalInputAxis);
        transform.Rotate(Vector3.left,  verticalInput *verticalInputAxis*Time.deltaTime, Space.World);
        transform.Rotate(Vector3.up, leftrightInputAxis*rotationSpeed);
        // get the user's vertical input
        //verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        // transform.Translate(Vector3.forward * 30);

        // tilt the plane up/down based on up/down arrow keys
        //transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
