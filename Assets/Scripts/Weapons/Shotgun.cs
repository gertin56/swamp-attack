using UnityEngine;

public class Shotgun : Weapon
{
    private float upRotate = 5;
    private float downRotate = -5;

    public override void Shoot(Transform shootPoint)
    {
        CreateRotatedBullet(upRotate, shootPoint);
        CreateRotatedBullet(0, shootPoint);
        CreateRotatedBullet(downRotate, shootPoint);
    }

    private void CreateRotatedBullet(float zRatate, Transform shootPoint)
    {
        Instantiate(Bullet, shootPoint.position, Quaternion.Euler(0, 0, zRatate));
    }
}
