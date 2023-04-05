using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;
public class PlayerMovementInputController : MonoBehaviour // todo : need to properly understand this script
{

    public Vector2 _move => _inp.GetMoveInput();
    public Vector2 _look => _inp.GetLookInput();
    public float aimValue;
    public float fireValue;

    public Vector3 nextPosition;
    public Quaternion nextRotation;

    public float rotationPower = 3f;
    public float rotationLerp = 0.5f;

    public float speed = 1f;
    public Camera camera;
    private InputController _inp;
    private void Awake()
    {
        _inp = GetComponent<InputController>();
    }

    public GameObject followTransform;

    private void Update()
    {
        
        ////Move the player based on the X input on the controller
        //transform.rotation *= Quaternion.AngleAxis(_look.x * rotationPower, Vector3.up);

        //put
        //followTransform.transform.rotation *= Quaternion.AngleAxis(_look.x * rotationPower, Vector3.up);


        //followTransform.transform.rotation *= Quaternion.AngleAxis(_look.y * rotationPower, Vector3.right);

        //var angles = followTransform.transform.localEulerAngles;
        //angles.z = 0;

        //var angle = followTransform.transform.localEulerAngles.x;

        ////Clamp the Up/Down rotation
        //if (angle > 180 && angle < 340)
        //{
        //    angles.x = 340;
        //}
        //else if (angle < 180 && angle > 40)
        //{
        //    angles.x = 40;
        //}



        //followTransform.transform.localEulerAngles = angles;




        //nextRotation = Quaternion.Lerp(followTransform.transform.rotation, nextRotation, Time.deltaTime * rotationLerp);

        //if (_move.x == 0 && _move.y == 0) 
        //{   
        //    nextPosition = transform.position;

        //    if (aimValue == 1)
        //    {
        //        //Set the player rotation based on the look transform
        //        transform.rotation = Quaternion.Euler(0, followTransform.transform.rotation.eulerAngles.y, 0);
        //        //reset the y rotation of the look transform
        //        followTransform.transform.localEulerAngles = new Vector3(angles.x, 0, 0);
        //    }

        //    return; 
        //}
        //float moveSpeed = speed / 100f;
        //Vector3 position = (transform.forward * _move.y * moveSpeed) + (transform.right * _move.x * moveSpeed);
        //nextPosition = transform.position + position;
        //transform.position = nextPosition;

        ////Set the player rotation based on the look transform
        //transform.rotation = Quaternion.Euler(0, followTransform.transform.rotation.eulerAngles.y, 0);
        ////reset the y rotation of the look transform
        //followTransform.transform.localEulerAngles = new Vector3(angles.x, 0, 0);
    }


}
