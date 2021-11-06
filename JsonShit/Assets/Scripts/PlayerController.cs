using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    CharacterController Cr;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    [SerializeField]
    Camera cam;

    public float cameraMoveSpeed;
    public float cameraShiftAdditionalSpeed;
    public float cameraMouseSensitivity;
    public bool cameraInvertMouse;
    public bool cameraAutoLockCursor;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {

    }

    void Update()
    {
        if (Cr.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        Cr.Move(moveDirection * Time.deltaTime);
    }
}