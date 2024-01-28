using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownMovement : MonoBehaviour
{
    
    [SerializeField] Rigidbody2D body;
    [SerializeField] float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        body.AddForce(moveSpeed * transform.right);
    }
}
