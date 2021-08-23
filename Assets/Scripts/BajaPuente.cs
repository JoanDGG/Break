using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BajaPuente : MonoBehaviour
{

    public GameObject puente;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //puente.GetComponent<Animator>().enabled = false;
        if (puente.transform.rotation.eulerAngles.z.CompareTo(355f) < 0)
        {
            puente.transform.Rotate(new Vector3(0f, 0f, 1f), Space.Self);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        puente.GetComponent<Animation>().Play();

    }

}
