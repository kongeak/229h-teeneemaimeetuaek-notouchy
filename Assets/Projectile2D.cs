using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile2D : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [SerializeField] private Transform target; // เปลี่ยนเป็น Transform เพราะไม่ต้องใช้ collider แล้ว
    [SerializeField] private Rigidbody2D bulletPrefab;

    void Start()
    {
        InvokeRepeating(nameof(ShootProjectile), 1f, 3f);
    }

    void ShootProjectile()
    {
        if (target == null) return;

        // สร้างกระสุน
        Rigidbody2D firedBullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);

        // คำนวณความเร็วและกำหนดให้กระสุน
        Vector2 velocity = CalculateProjectileVelocity(shootPoint.position, target.position, 1f);
        firedBullet.velocity = velocity;
    }

    Vector2 CalculateProjectileVelocity(Vector2 origin, Vector2 target, float time)
    {
        Vector2 distance = target - origin;
        float velocityX = distance.x / time;
        float velocityY = distance.y / time + 0.5f * Mathf.Abs(Physics2D.gravity.y) * time;

        return new Vector2(velocityX, velocityY);
    }
}