using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    Rigidbody capsule;

    void Start()
    {
        capsule = transform.GetComponent<Rigidbody>();
    }

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            capsule.AddForce(Vector3.up * 300);
        }
    }
}
