using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [SerializeField]
    float _acceleration;

    Rigidbody m_rigibBody;
    Camera m_camera;

    [SerializeField]
    float jumpForce;
    [SerializeField]
    LayerMask groundLayer;
    SphereCollider sphereCollider;

    void Start()
    {
        m_rigibBody = GetComponent<Rigidbody>();
        m_camera = Camera.main;
        sphereCollider = GetComponent<SphereCollider>();

        m_rigibBody.maxAngularVelocity = 50;

    }

    void FixedUpdate()
    {
        Vector3 moveVector;

        moveVector = GetMovementVector();
        MovePlayer(moveVector, _acceleration);

        if (IsGrounded() && Input.GetKey(KeyCode.Space))
        {
            // m_rigibBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            m_rigibBody.velocity += Vector3.up * jumpForce;

        }

    }

    void MovePlayer(Vector3 moveVector, float acceleration)
    {

        Vector3 outVelocity = m_rigibBody.angularVelocity;
        outVelocity += moveVector * acceleration * Time.deltaTime;

        m_rigibBody.angularVelocity = outVelocity;


    }

    Vector3 GetMovementVector()
    {

        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            move += Vector3.right;

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            move -= Vector3.right;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            move -= Vector3.forward;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            move += Vector3.forward;

        return move.normalized;

    }

    private bool IsGrounded()
    {
        return Physics.CheckCapsule(sphereCollider.bounds.center,
            new Vector3(sphereCollider.bounds.center.x, sphereCollider.bounds.min.y, sphereCollider.bounds.center.z),
            sphereCollider.radius * 0.6f, groundLayer);

    }
}
