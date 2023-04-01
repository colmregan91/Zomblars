using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    private InputController _InputController;
    [SerializeField] private Transform followTransform;
    [SerializeField] private float rotationPower;
    private Quaternion nextRotation;
    [SerializeField] private float rotationLerp;
    
    private Vector3 angles;
    private float Xangle;

    public Vector3 GetAngles()
    {
        return angles;
    }

    private Vector2 LookDir => _InputController.GetLookInput();

    private float VertLook => LookDir.y;
    private float HorzLook => LookDir.x;
    private void Start()
    {
        _InputController = GetComponent<InputController>();
    }



    private void Update()
    {
        //Move the player based on the X input on the controller
        //transform.rotation *= Quaternion.AngleAxis(_look.x * rotationPower, Vector3.up);

        //Rotate the Follow Target transform based on the input
        followTransform.transform.rotation *= Quaternion.AngleAxis(HorzLook * rotationPower, Vector3.up);

        followTransform.transform.rotation *= Quaternion.AngleAxis(VertLook * rotationPower, Vector3.right);
        
        angles = followTransform.transform.localEulerAngles;
        angles.z = 0;
        
        Xangle = followTransform.transform.localEulerAngles.x;

        //Clamp the Up/Down rotation
        if (Xangle > 180 && Xangle < 340)
        {
            angles.x = 340;
        }
        else if (Xangle < 180 && Xangle > 40)
        {
            angles.x = 40;
        }


        followTransform.transform.localEulerAngles = angles;

          nextRotation = Quaternion.Lerp(followTransform.transform.rotation, nextRotation, Time.deltaTime * rotationLerp);
    }
}