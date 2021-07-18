using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject _lastGround;
   
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            groundCreate();
        }
    }

   
    void Update()
    {
      
    }

    public void groundCreate()
    {
        Vector3 direction;
        if (Random.Range(0, 2) == 0)
        {
            direction = Vector3.left;
        }
        else
        {
            direction = Vector3.forward;
        }
        _lastGround = Instantiate(_lastGround, _lastGround.transform.position + direction,
            _lastGround.transform.rotation);
    }
    
}
