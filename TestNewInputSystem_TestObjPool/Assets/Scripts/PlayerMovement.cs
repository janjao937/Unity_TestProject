using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using static PlayerControl;

public class PlayerMovement : MonoBehaviour, IGameControlActions
{
    [SerializeField] private float movementSpeed = 10;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float jumpForce;
    private PlayerControl playerControl;

    //private InputAction movement;
   
    

    private Vector3 Direction;

    private void Awake()
    {
        //movement = playerControl.GameControl.Movement;
        playerControl = new PlayerControl();
        playerControl.GameControl.SetCallbacks(this);
        
    }


    void Update()
    {
        transform.position += Position();
       
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        Direction = new Vector3(direction.x, 0, direction.y);
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        //Jump();
    }

    private Vector3 Position()
    {
        return Direction * movementSpeed * Time.deltaTime;
    }
    private void Jump()
    {
       //rb.velocity = new Vector3(0,20* jumpForce * Time.deltaTime, 0);
       Debug.Log("Jump");
      
    }

    private void OnEnable()
    {
        playerControl.Enable();
    }
    private void OnDisable()
    {
        playerControl.Disable();
    }

    
}
