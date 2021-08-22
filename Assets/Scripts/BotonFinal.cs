using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonFinal : MonoBehaviour
{

    public Canvas canvasFinal;
    public Sprite buttonPressed;

    // Start is called before the first frame update
    void Start()
    {
        canvasFinal.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")){
            print("Boton presionado");
            gameObject.GetComponent<SpriteRenderer>().sprite = buttonPressed;
            canvasFinal.gameObject.SetActive(true);
        }
    }
}
