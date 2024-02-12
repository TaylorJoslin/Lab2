using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grounded : MonoBehaviour
{
    [SerializeField] private bool isGrounded;
    [SerializeField] private float groundDistance;
    [SerializeField] private LayerMask groundMask;

  

    [SerializeField] private Rigidbody rb;

    

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position, groundDistance, groundMask);

        if (!isGrounded)
        {
            rb.isKinematic = false;     
        }


    }

  

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, groundDistance);
       
    }
}
