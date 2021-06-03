using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float moveSpeed = 15f;

    void Start()
    {
        
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;        
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount,0);
        transform.Rotate(0,0, -steerAmount);
    }
}
