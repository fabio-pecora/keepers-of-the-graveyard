using UnityEngine;
using System.Collections;

public class backInTheMainGraveyard : MonoBehaviour
{

    // Use this for initialization
    void OnCollisionEnter2D(Collision2D Colider)
    {
        if (Colider.gameObject.tag == "Player") ;
        Application.LoadLevel("Graveyard Scene");
    }
}