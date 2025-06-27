using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Mouse sensitivity
    private float rotateSpeed = 200.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // Invert horizontal rotation by multiplying Mouse X by -1
            transform.localEulerAngles = new Vector3(
                transform.localEulerAngles.x + Input.GetAxis("Mouse Y") * Time.deltaTime * rotateSpeed,
                transform.localEulerAngles.y - Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed // Inverted horizontal
            );
        }
    }
}