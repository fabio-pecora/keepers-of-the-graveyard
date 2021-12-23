using UnityEngine;
using System.Collections;

public class victoryOrLosingScene : MonoBehaviour
{
    void loadScene()
    {
        if (Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(2))
        {
            Application.LoadLevel("LosingScene");
        }
        else
        {
            Application.LoadLevel("Graveyard Scene");
        }
    }

}
