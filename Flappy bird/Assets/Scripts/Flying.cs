using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    Rigidbody2D capsule;

    void Start()
    {
        capsule = transform.GetComponent<Rigidbody2D>();
    }

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            capsule.velocity = Vector2.up * 7;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collided");
        Debug.Log(collision.gameObject.transform.parent.name);
    }
}
