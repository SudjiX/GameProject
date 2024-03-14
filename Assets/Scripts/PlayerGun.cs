using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField]
    Transform firingPoint;

    [SerializeField]
    float firingSpeed;

    public static PlayerGun Instance;

    void Awake ()
    {
        Instance = GetComponent<PlayerGun>();
    }

    private float lastTimeShot = 0;

    public void Shoot ()
    {
        _ = lastTimeShot + firingSpeed < Time.time;
        lastTimeShot = Time.time;
        
    }
}
