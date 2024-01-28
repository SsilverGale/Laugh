using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Honk Honk");
        Debug.Log("colliding");
    }
}
