using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    float xRotate;
    float yRotate;
    float curXRotate;
    float curYRotate;

    private void Update()
    {
        xRotate = Input.GetAxisRaw("Mouse X");
        yRotate = Input.GetAxisRaw("Mouse Y");

        if (Input.GetKey(KeyCode.Mouse0))
        {
            curXRotate += xRotate;
            curYRotate += yRotate;

            curYRotate = Mathf.Clamp(curYRotate, -40, 20);

            transform.eulerAngles = new Vector3(-curYRotate, curXRotate, 0);
        }
    }
}
