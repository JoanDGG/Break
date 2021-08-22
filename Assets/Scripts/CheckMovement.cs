using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMovement : MonoBehaviour
{

    new private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0.1) || (Mathf.Abs(Input.GetAxisRaw("Vertical")) > 0.1))
        {
            GameManager.moving = true;
        }
        else
        {
            GameManager.moving = false;
        }
    }
}
