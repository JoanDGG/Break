using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey && transform.GetChild(0).gameObject.activeSelf)
        {
            transform.GetChild(0).GetComponent<FadeOut>().EfectoOut();
        }
    }
}
