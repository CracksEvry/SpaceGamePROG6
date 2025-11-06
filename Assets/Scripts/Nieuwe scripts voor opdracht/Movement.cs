using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool useInput = false;

    void Update()
    {
        float input = 1f;

        if (useInput)
        {
            input = Input.GetAxis("Vertical");
        }

        transform.position += transform.forward * moveSpeed * input * Time.deltaTime;
    }
}