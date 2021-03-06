using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject sign;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            sign.GetComponent<FadeOut>().EfectoText();

            GameManager.PX = transform.position.x;
            GameManager.PY = transform.position.y;
            print(GameManager.PX);
            print(GameManager.PY);
        }
    }
}
