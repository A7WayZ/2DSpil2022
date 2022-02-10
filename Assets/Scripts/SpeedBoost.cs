using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{

    public float SpeedDuration = 3;
    public float SpeedBoostAmount = 750;

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
            collision.GetComponent<PlayerMovement>().SpeedPowerup(SpeedDuration, SpeedBoostAmount);
            Destroy(gameObject);
        }
    }
}
