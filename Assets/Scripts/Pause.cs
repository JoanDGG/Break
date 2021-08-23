using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{

    public GameObject Menu;
    public Image image;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 0 && GameManager.moving)
        {
            image.enabled = true;
            Menu.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void Pausar()
    {
        print("Paused");
        image.enabled = false;
        Menu.SetActive(true);
        Time.timeScale = 0;
    }
}
