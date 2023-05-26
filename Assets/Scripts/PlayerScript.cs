using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * moveSpeed;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -1 * rotateSpeed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -1 * moveSpeed;
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 1 * rotateSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * moveSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * moveSpeed;
        }
    }
}
