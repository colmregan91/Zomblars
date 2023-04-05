using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotationclamp : MonoBehaviour
{
    private Transform followTransform;
    public float rotationPower = 3f;
    public Vector2 _look => _inp.GetLookInput();
    private InputController _inp;
    // Start is called before the first frame update
    void Start()
    {
        _inp = GetComponent<InputController>();
        followTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate the Follow Target transform based on the in
    }
}
