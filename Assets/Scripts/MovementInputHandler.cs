using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInputHandler : MonoBehaviour
{
    public Transform CubeTramsform;
    public KeyCode ForwardKey = KeyCode.W;
    public KeyCode BackwardKey = KeyCode.S;
    public KeyCode TurnLeftKey = KeyCode.A;
    public KeyCode TurnRighttKey = KeyCode.D;
   
    // Update is called once per frame
    private void Start()
    {
        if(CubeTramsform == null)
        {
            CubeTramsform = transform;
        }
    }
    void Update()
    {
        if(Input.GetKey(ForwardKey))
        {
            CubeTramsform.Translate(Vector3.forward);
        }
        if (Input.GetKey(BackwardKey))
        {
            CubeTramsform.Translate(Vector3.back);
        }
        if (Input.GetKey(TurnLeftKey))
        {
            CubeTramsform.transform.Rotate(0,-1,0);
        }
        if (Input.GetKey(TurnRighttKey))
        {
            CubeTramsform.transform.Rotate(0, 1, 0);
        }
    }
}
