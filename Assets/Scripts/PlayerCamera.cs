using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public MovementInputHandler player;
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {    
        pos = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + pos;
    }
}
