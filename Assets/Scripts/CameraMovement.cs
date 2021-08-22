using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private float PastX;
    private float PastY;

    // Start is called before the first frame update
    void Start()
    {
        PastX = 0.0f;
        PastY = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if((PastX != GameManager.CameraX) || (PastY != GameManager.CameraY))
        {
            transform.Translate(GameManager.CameraX, GameManager.CameraY, 0.0f);
            PastX = GameManager.CameraX;
            PastY = GameManager.CameraY;
        }
    }
}
