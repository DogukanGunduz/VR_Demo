using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public float mouseSensitivity = 1000f;
    public float clampAngle = 180f;

    private float rotY = 0.0f;
    private float rotX = 0.0f;
    private float rotZ = 0.0f;

    float mouseZ;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
        rotZ = rot.z;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");

        rotY += mouseX * mouseSensitivity * Time.deltaTime;
        rotX += mouseY * mouseSensitivity * Time.deltaTime;
        rotZ += mouseY * mouseSensitivity * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);
        Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
        transform.rotation = localRotation;

        if (Input.GetKey(KeyCode.LeftControl))
        {
            mouseZ += mouseX * mouseSensitivity * Time.deltaTime * 20f;
            mouseZ = Mathf.Clamp(mouseZ, -90, 90);
            Quaternion localRotation2 = Quaternion.Euler(0, 0, rotZ);
            transform.rotation = localRotation2;
        }


    }
}
