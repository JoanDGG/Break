using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    public GameObject players;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            print("You died");
            Instantiate(players, new Vector3(GameManager.PX, GameManager.PY, 0.0f), Quaternion.identity);
            Destroy(transform.parent.gameObject);
        }
    }
}
