using UnityEngine;
using System.Collections;

public class changingScreen : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel("Tutorial");
        }

    }
}
