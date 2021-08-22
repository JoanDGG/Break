using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoGeneral : MonoBehaviour
{
    public float velocidad = 7;
    new private Rigidbody2D rigidbody;
    private float movHorizontal;
    private float movVertical;
    //private Animator anim;
    Vector2 lookDirection = new Vector2(1, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        GameManager.scene = SceneManager.GetActiveScene().buildIndex + 1;
        rigidbody = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movVertical = 0.0f;
        movHorizontal = 0.0f;
        string name = this.gameObject.name;
        switch (name)
        {
            case "Bob":
                if (Input.GetKey("w"))
                {
                    movVertical = 0.5f;
                }
                if (Input.GetKey("a"))
                {
                    movHorizontal = -0.5f;
                }
                if(Input.GetKey("s"))
                {
                    movVertical = -0.5f;
                }
                if (Input.GetKey("d"))
                {
                    movHorizontal = 0.5f;
                }
                    break;
            case "Jerry":
                if (Input.GetKey("up"))
                {
                    movVertical = 0.5f;
                }
                if (Input.GetKey("left"))
                {
                    movHorizontal = -0.5f;
                }
                if (Input.GetKey("down"))
                {
                    movVertical = -0.5f;
                }
                if (Input.GetKey("right"))
                {
                    movHorizontal = 0.5f;
                }
                break;
        }
       
        Vector2 move = new Vector2(movHorizontal, movVertical);

        //if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        //{
           // lookDirection.Set(move.x, move.y);
           // lookDirection.Normalize();
        //}

        //anim.SetFloat("Look X", lookDirection.x);
        //anim.SetFloat("Look Y", lookDirection.y);
        //anim.SetFloat("Speed", move.magnitude);

        rigidbody.velocity = new Vector2(movHorizontal * velocidad, movVertical * velocidad);
    }
}
