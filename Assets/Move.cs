using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private InputController _InputController;
    private Look _look;
    
    private Vector3 nextPosition;
    [SerializeField] private int aimValue = 0;
    [SerializeField] private Transform followTransform;
    [SerializeField] private float speed = 3.5f;

    private Vector2 Movement => _InputController.GetMoveInput();

    private float VertMovement => Movement.y;
    private float HorzMovement => Movement.x;

    private Vector3 LookAngles => _look.GetAngles();
    private float VertLook => LookAngles.y;
    private float HorzLook => LookAngles.x;
    

    // Start is called before the first frame update
    void Start()
    {
        _InputController = GetComponent<InputController>();
        _look = GetComponent<Look>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (HorzMovement == 0 && VertMovement == 0) 
        {   
            nextPosition = transform.position;
        
            if (aimValue == 1)
            {
                //Set the player rotation based on the look transform
                transform.rotation = Quaternion.Euler(0, followTransform.transform.rotation.eulerAngles.y, 0);
                //reset the y rotation of the look transform
                followTransform.transform.localEulerAngles = new Vector3(HorzLook, 0, 0);
            }
        
            return; 
        }

        transform.position += new Vector3(HorzMovement * speed, 0, VertMovement * speed);
        // float moveSpeed = speed;
        // Vector3 position = (transform.forward * VertMovement * moveSpeed) + (transform.right * HorzMovement * moveSpeed) * Time.deltaTime;
        // nextPosition = transform.position + position;        
        // transform.position = nextPosition;
        // //Set the player rotation based on the look transform
        // transform.rotation = Quaternion.Euler(0, followTransform.transform.rotation.eulerAngles.y, 0);
        // //reset the y rotation of the look transform
        // followTransform.transform.localEulerAngles = new Vector3(HorzLook, 0, 0);
    }
}