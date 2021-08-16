using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        // Fetch the Rigidbody component from the GameObject which has the script attached
        rb = GetComponent<Rigidbody>();
    }

    public void Fire()
    {
        // Apply a force to the rigidbody
        if (rb)
        {
            rb.AddForce(0, 10.0F, 10.0F, ForceMode.Impulse);
        }
    }
}
