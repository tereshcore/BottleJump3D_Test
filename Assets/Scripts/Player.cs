using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Animator anim;
    [SerializeField] private string animationName;
    [SerializeField] private Vector2 force;
    private bool isGrounded;

    public void Jump()
    {
        if(isGrounded)
        {
            rb.AddForce(force.x, force.y, 0);
            isGrounded = false;
            anim.Play(animationName);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
