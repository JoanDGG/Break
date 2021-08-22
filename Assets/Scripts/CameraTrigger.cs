using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{

    new private string name;

    // Start is called before the first frame update
    void Start()
    {
        name = this.gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            switch (name)
            {
                case "1":
                    GameManager.CameraX = 20.0f;
                    break;
                case "2":
                    GameManager.CameraX = 40.0f;
                    break;
            }
        }
    }
}
