using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerup : MonoBehaviour
{

    public float JumpPowerDuration = 3;
    public float JumpPowerAmount = 550;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerMovement>().JumpPowerup(JumpPowerDuration, JumpPowerAmount);
            Destroy(gameObject);
        }
    }
}
