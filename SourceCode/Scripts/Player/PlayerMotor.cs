using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Funcionalidad de los movimientos del personaje y los atributos y parametros de estos
public class PlayerMotor : MonoBehaviour, IDataPersistence
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool isGrounded;
    public float speed = 5f; 
    public float gravity = -9.8f;
    public float jumpHeight = 3f;
    public bool crouching, sprinting, lerpCrouch;
    public float crouchTimer;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = controller.isGrounded;
        if (lerpCrouch)
        {
            crouchTimer += Time.deltaTime;
            float p = crouchTimer/1;
            p += p;
            if (crouching)
                controller.height = Mathf.Lerp(controller.height, 1 ,p);
            else
                controller.height = Mathf.Lerp(controller.height, 2 ,p);

            if (p > 1)
            {
                lerpCrouch = false;
                crouchTimer = 0f;
            }
        }
    }
    public void LoadData(GameData data)
    {
        this.transform.position = data.playerPosition;
    }

    public void SaveData(ref GameData data)
    {   
        data.playerPosition = this.transform.position;
    }
    
    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        playerVelocity.y += gravity * Time.deltaTime;
        if(isGrounded && playerVelocity.y < 0)
            playerVelocity.y = -2f;
        controller.Move(playerVelocity * Time.deltaTime);
    }
    public void Jump()
    {
        if(isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }
    }
    public void Crouch()
    {
        crouching = !crouching;
        crouchTimer = 0;
        lerpCrouch = true;
        if(crouching)
            speed = 3;
        else
            speed = 8;
    }
    public void Sprint()
    {
        sprinting = !sprinting;
        if(!crouching)
        {
            if(sprinting)
                speed = 13;
            else
                speed = 8;
        }
    }
}
