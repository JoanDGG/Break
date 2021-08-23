using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{

    new private string name;
    public GameObject camera;

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
            camera.GetComponent<SmoothFollow>().target = this.gameObject;
        }
    }
}
