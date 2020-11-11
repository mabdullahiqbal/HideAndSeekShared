using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    private string movinput = "Vertical";
    private string turninput = "Horizontal";
    public float rotation_rate = 360;
    public float mov_speed = 50;
    private Rigidbody rb;
    private CharacterController cc;

    
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        cc = GetComponent<CharacterController>();

    }
    void FixedUpdate()
    {
        float movAxis = Input.GetAxis(movinput);
        float turnAxis = Input.GetAxis(turninput);
         Apply_Input(movAxis,turnAxis);
         

    }
    private void Apply_Input(float mov,float turn)
    {
        Move(mov);
        Turn(turn);

    }
    private void Move(float input)
    {
        //transform.Translate(Vector3.forward * input * mov_speed);
       // rb.AddForce(Vector3.forward * input * mov_speed,ForceMode.VelocityChange);
       cc.Move(Vector3.forward * input * mov_speed);

    }
    private void Turn(float input)
    {
        
       // transform.Translate(Vector3.right * input * mov_speed);
       //rb.AddForce(Vector3.right * input * mov_speed,ForceMode.VelocityChange);
       cc.Move(Vector3.right * input * mov_speed);

    }
}
