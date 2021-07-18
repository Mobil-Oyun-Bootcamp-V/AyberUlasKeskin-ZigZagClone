using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMove : MonoBehaviour
{
    private Vector3 direction;
    public GroundSpawner _GroundSpawnerScript;
    [SerializeField] public float speed;
    public float addSpeed;
    public GameObject RetryButton;
    public static bool fallControl;
    
    void Start()
    {
        
        if(Input.GetButtonDown("Fire1"))
        {
            
            UIManager.instance.GameMain();
            direction= Vector3.forward;
            fallControl = false;
            
            
        }
        else
        {
            UIManager.instance.GameStart();
            return;
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 0.5)
        {
            fallControl = true;
            UIManager.instance.GameOver();
            
            
        }
        if (fallControl == true)
        {
            SceneManager.LoadScene(1);
            return;
        }
        if (Input.GetButtonDown("Fire1"))
        {UIManager.instance.GameMain();
            if (direction.x == 0)
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }

            speed += addSpeed * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        Vector3 move = direction * Time.deltaTime * speed;
        transform.position += move;
    }

    private void OnCollisionExit(Collision _collision)
    {
        if (_collision.gameObject.tag == "Ground")
        {
            
            _collision.gameObject.AddComponent<Rigidbody>();
            _GroundSpawnerScript.groundCreate();
            StartCoroutine(DestroyGround(_collision.gameObject)); 
        }
        else if (_collision.gameObject.tag == "Card")
        {
            _GroundSpawnerScript.groundCreate();
            StartCoroutine(DestroyGround(_collision.gameObject));
        }
    }

    IEnumerator DestroyGround(GameObject _groundDestroy)
    {
        yield return new WaitForSeconds(3f);
        Destroy(_groundDestroy);
    }
}
