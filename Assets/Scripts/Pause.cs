using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{

    public GameObject Menu;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 0 && GameManager.moving)
        {
            print("Pause off");
            //transform.GetChild(0).GetComponent<FadeOut>().EfectoOut();
            Menu.SetActive(false);
            Time.timeScale = 1;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausar();
        }
    }

    public void Pausar()
    {
        print("Paused");

        Menu.SetActive(true);
        //transform.GetChild(0).GetComponent<FadeOut>().EfectoIn();
        Time.timeScale = 0;
    }
}
