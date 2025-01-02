using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk_around: MonoBehaviour
{
    private enum State
    {
        MoveForward,
        Turn,
        Idle 
    }

    private State currentState = State.MoveForward;
    public float speed = 5.0f;
    public float turnSpeed = 90; 

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("SimpleAIWithRigidbodyStopAndTurn requires a Rigidbody component.");
        }
    }

    private void FixedUpdate()
    {
        switch (currentState)
        {
            case State.MoveForward:
                MoveForward();
                break;
            case State.Turn:
                
                break;
        }
    }

    private void MoveForward()
    {
        Vector3 movement = transform.forward * speed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Assuming your walls have the tag "Wall"
        if (collision.gameObject.CompareTag("Wall"))
        {
            currentState = State.Idle; // Stop moving by transitioning to the Idle state
            rb.velocity = Vector3.zero; // Stop any current movement immediately
            rb.angularVelocity = Vector3.zero; // Stop any rotational movement
            Invoke("Turn", 0.5f); // Wait for a short delay before starting to turn
        }
    }

    private void Turn()
    {
        // Rotate 90 degrees to the right
        Quaternion rotation = Quaternion.Euler(0, 90, 0);
        rb.MoveRotation(rb.rotation * rotation);
        currentState = State.MoveForward; // Resume moving forward after the turn
    }
}
