using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform _ballPosition;

    private Vector3 deltaPosition;
    // Start is called before the first frame update
    void Start()
    {
        deltaPosition = transform.position - _ballPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (BallMove.fallControl == false)
        {
            transform.position = _ballPosition.position + deltaPosition;
        }
        else if(BallMove.fallControl == true)
        {
            deltaPosition = transform.position - _ballPosition.position;
            
        }
        
    }
}
