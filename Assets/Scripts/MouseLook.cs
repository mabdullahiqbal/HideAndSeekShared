using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float M_Sensitivity = 100f;
    public Transform player;
    public Vector3 offset;
   
   
    void FixedUpdate()
    {
        float mov_x = Input.GetAxis("Mouse X") * M_Sensitivity * Time.deltaTime;
        float mov_y = Input.GetAxis("Mouse Y") * M_Sensitivity * Time.deltaTime;
        
        transform.Rotate(Vector3.up * mov_x);

    }

        
}

