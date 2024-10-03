using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int health = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (health <= 0) {
            Debug.Log("Health < 0");
            // Trigger game over
        } else if (health < 50) {
            // Change player color to indicate low health
            Debug.Log("Health >0");
        }
    }
}
