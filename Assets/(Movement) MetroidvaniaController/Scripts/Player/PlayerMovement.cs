using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool dash = false;

	//bool dashAxis = false;
	
	// Update is called once per frame
	void Update () {

        string name = this.gameObject.name;
        float movHorizontal = 0.0f;
        bool jumpInput = false;

        switch (name)
        {
            case "Bob":
                if (Input.GetKey("a")) //Left
                {
                    movHorizontal = -0.5f;
                }
                else if (Input.GetKey("d")) //Right
                {
                    movHorizontal = 0.5f;
                }
                if (Input.GetKeyDown("c")) //Jump
                {
                    jumpInput = true;
                }
                if (Input.GetKeyDown("v")) //Dash
                {
                    dash = true;
                }
                break;
            case "Jerry":
                if (Input.GetKey("left")) //Left
                {
                    movHorizontal = -0.5f;
                }
                else if (Input.GetKey("right")) //Right
                {
                    movHorizontal = 0.5f;
                }
                if (Input.GetKeyDown(".")) //Jump
                {
                    jumpInput = true;
                }
                if (Input.GetKeyDown("-")) //Dash
                {
                    dash = true;
                }
                break;
        }

		horizontalMove = movHorizontal * runSpeed;

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (jumpInput)
		{
			jump = true;
		}

        //Dash diagonal
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)))
        {
            //Dash Izquierda-Arriba
            controller.dashType = 5;
            print(controller.dashType);
        }
        else if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)))
        {
            //Dash Abajo-Izquierda
            controller.dashType = 6;
            print(controller.dashType);
        }
        else if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)))
        {
            //Dash Derecha-Abajo
            controller.dashType = 7;
            print(controller.dashType);
        }
        else if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)))
        {
            //Dash Arriba-Derecha
            controller.dashType = 8;
            print(controller.dashType);
        }

        //Dash cruz
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Dash Izquierda
            controller.dashType = 1;
            print(controller.dashType);
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Dash Abajo
            controller.dashType = 2;
            print(controller.dashType);
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Dash Derecha
            controller.dashType = 3;
            print(controller.dashType);
        }
        else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Dash Arriba
            controller.dashType = 4;
            print(controller.dashType);
        }

        /*if (Input.GetKeyDown(KeyCode.C))
		{
            dash = true;
		}*/

		/*if (Input.GetAxisRaw("Dash") == 1 || Input.GetAxisRaw("Dash") == -1) //RT in Unity 2017 = -1, RT in Unity 2019 = 1
		{
			if (dashAxis == false)
			{
				dashAxis = true;
				dash = true;
			}
		}
		else
		{
			dashAxis = false;
		}
		*/

	}

	public void OnFall()
	{
		animator.SetBool("IsJumping", true);
	}

	public void OnLanding()
	{
		animator.SetBool("IsJumping", false);
	}

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, jump, dash);
		jump = false;
		dash = false;
	}
}
