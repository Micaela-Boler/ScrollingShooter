using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Armas : MonoBehaviour
{
    [SerializeField] Bullet bulletPrefab;

    public virtual void Disparar(Transform spawn)
    {
        Bullet projectile = Instantiate(bulletPrefab, spawn.position, transform.rotation);
        projectile.LaunchBullet(transform.right);
    }
}
