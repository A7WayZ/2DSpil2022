using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public PointManager pm;

    // Start is called before the first frame update
    void Start()
    {

        pm = GameObject.Find("PointManager").GetComponent<PointManager>();

    }

    // Update is called once per frame
    void Update()
    {   

     }

     private void OnTriggerEnter2D(Collider2D collision)
     {
        if (collision.tag == "Player")
        {
            pm.AddPoint(1);
            Destroy(gameObject);
        }
     }
}
