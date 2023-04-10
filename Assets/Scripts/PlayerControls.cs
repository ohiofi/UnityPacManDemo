using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    
    public float moveSpeed = 1f;
    public float turnSpeed = 1f;
    private Rigidbody rb;
    private Vector2 turn = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb);
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate() {
        turn.x += Input.GetAxis("Mouse X") * turnSpeed;
        turn.y += Input.GetAxis("Mouse Y");
        transform.localRotation = Quaternion.Euler(0, turn.x, 0);
        // Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed;
        Vector3 move = rb.rotation * new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeed;
        rb.AddForce(move);
    }
}
