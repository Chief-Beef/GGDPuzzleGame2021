using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POV : MonoBehaviour
{
    public static POV Instance;

    public Vector2 rotation = new Vector2(0, 0);
    public Vector2 playerRotation = new Vector2(0, 0);

    public float sensitivity;
    public float xRotation = 0;
    public float yRotation = 0;

    public Transform playerBody;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        //POV

        //Testing so I can see the numbers
        yRotation += Input.GetAxis("Mouse X");
        xRotation -= Input.GetAxis("Mouse Y");

        xRotation = Mathf.Clamp(xRotation, -90f/sensitivity, 90f/sensitivity);

        rotation.y = yRotation;
        rotation.x = xRotation;
        playerRotation.y = yRotation;

        this.transform.eulerAngles = (Vector2)rotation * sensitivity;
        playerBody.transform.eulerAngles = (Vector2)playerRotation * sensitivity;
        //End POV


    }
}
