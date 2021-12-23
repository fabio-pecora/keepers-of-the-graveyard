using UnityEngine;
using System.Collections;

public class enteringMainTomb : MonoBehaviour
{

    // Use this for initialization
    void OnCollisionEnter2D(Collision2D Colider)
    {
        if (Colider.gameObject.tag == "Player") ;
        Application.LoadLevel("Final Fight");
    }
}