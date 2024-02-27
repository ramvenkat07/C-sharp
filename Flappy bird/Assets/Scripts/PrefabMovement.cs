using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabMovement : MonoBehaviour, SpeedInterface
{
    float speed;
    private void Start()
    {
        speed = 0.1f;
    }
    void SpeedInterface.ChangeSpeed()
    {

    }
    void Update()
    {
        transform.Translate(Vector3.left * speed);
        if(transform.position.x <= -25)
        {
            Destroy(gameObject);
        }
    }
}
