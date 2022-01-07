using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 7f;
 
    private Rigidbody2D playerRb;
    private Transform playerRotation;
 
    void Awake()
    {
        playerRotation = GetComponent<Transform>();
        playerRb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        ContinuousMovement();
    }
 
    void Update()
    {
        MoveRotation();
    }
 
    public void ContinuousMovement()
    {
        //playerRb.MovePosition(transform.position + transform.forward * moveSpeed * Time.deltaTime);
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        playerRb.MovePosition(transform.position + input * Time.deltaTime * moveSpeed);
    }

    void MoveRotation()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {          
            playerRotation.rotation = Quaternion.Euler(0f, 180f, 0f);         
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {  
            playerRotation.rotation = Quaternion.Euler(0f, 0f, 90f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {      
            playerRotation.rotation = Quaternion.Euler(0f, 0f, 0f);                      
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerRotation.rotation = Quaternion.Euler(0f, 0f, -90f);
        }
    }
}
