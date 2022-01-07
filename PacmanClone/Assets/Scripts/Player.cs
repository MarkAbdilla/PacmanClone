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
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        if (Input.GetAxisRaw("Horizontal") > 0f || Input.GetAxisRaw("Horizontal") < 0f) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(h, 0) * moveSpeed;
        }
        else if (Input.GetAxisRaw("Vertical") > 0f || Input.GetAxisRaw("Vertical") < 0f) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * moveSpeed;
        }
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
