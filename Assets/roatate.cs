using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roatate : MonoBehaviour
{
    public float rotationSpeed = 500f;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        float rotation = rotationSpeed * Time.deltaTime;

      //  transform.Rotate(0f, 0f, rotation, Space.Self);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime, Space.Self);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime, Space.Self);
        }
    }
}






