using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    //Rotations
    float x = 0f;
    float y = 0f;

    [Tooltip ("This controls the look around sensitivity")]
    public float sensitivity = 15f;


   
    void Update()
    {
        //Lookaround Boundaries
        if (y > 90)
        {
            y = 90;
        }
        if (y < -90)
        {
            y = -90;
        }
        if (x> 90)
        {
            x = 90;
        }
        if (x < -90)
        {
            x = -90;
        }

        Cursor.lockState = CursorLockMode.Locked;
        //Movement
        y += Input.GetAxis("Mouse X") * sensitivity;
        x += Input.GetAxis("Mouse Y") * -1 * sensitivity;
        transform.localEulerAngles = new Vector3(x, y, 0);
    }
}
