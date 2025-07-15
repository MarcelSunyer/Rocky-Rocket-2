using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class ShipController : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float moveSpeed = 5f;
    float horizontalMovement;
    float verticalMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2D.rotation += horizontalMovement;
    }

    public void Move(InputAction.CallbackContext context)
    {
        horizontalMovement = context.ReadValue<Vector2>().x;
    }
}
