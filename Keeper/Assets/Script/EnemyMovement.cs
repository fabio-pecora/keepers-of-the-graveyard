using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    bool BorderLeft = false;
    bool BorderRight = true;
    

    // Start is called before the first frame update
    void Start()
    {
        speed = -1;
    }

    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "BorderLeft")
        {
            BorderRight = false;
            BorderLeft = true;
            speed *= -1;
        }
        else
        {
            BorderRight = true;
            BorderLeft = false;
            speed *= -1;
        }
    }
    void Update()
    {
        this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }
}
