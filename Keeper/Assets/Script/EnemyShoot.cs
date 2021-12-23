using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform EnemyFirePoint;
    public GameObject bulletPrefab;
    float timer = 0;
    int totalObjectCount = 0;
    float objectLimit = 100;

    // Update is called once per frame
    void Update()
    {
        if (totalObjectCount > objectLimit)
        {
            return;
        }

        timer += Time.deltaTime;

        if (timer >= 0.5)
        {
            Instantiate(bulletPrefab, EnemyFirePoint.position, EnemyFirePoint.rotation);
            
            timer = 0f;
            totalObjectCount++;


        }


    }
 

    /*void Shoot()
    {
        
        
        Instantiate(bulletPrefab, EnemyFirePoint.position, EnemyFirePoint.rotation);
        
        
    }*/

}
