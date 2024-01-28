using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] Rigidbody2D body;
    [SerializeField] float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            body.AddForce(moveSpeed * transform.right);
            Debug.Log("right");
        }
        if (Input.GetKey(KeyCode.A))
        {
            body.AddForce(-moveSpeed * transform.right);
            Debug.Log("left");
        }
    }
}
