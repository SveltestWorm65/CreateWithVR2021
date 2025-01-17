using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject projectile;
    public GameObject spawnPoint;

    public TVCameraControl tvControl;

   public void Shoot()
    {
        Instantiate(projectile, spawnPoint.transform.position, spawnPoint.transform.rotation);
       // tvControl.AddToScore();
    }
}
