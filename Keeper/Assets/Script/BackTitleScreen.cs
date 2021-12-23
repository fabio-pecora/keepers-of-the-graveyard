using UnityEngine;
using System.Collections;

public class BackTitleScreen : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel("Title Screen");
        }

    }
}