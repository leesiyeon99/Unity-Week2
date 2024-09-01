using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooterCoroutine : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float repeatTime;

    private Coroutine bulletSpawnRoutine;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bulletSpawnRoutine = StartCoroutine(BulletSpawnRoutine());
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            StopCoroutine(bulletSpawnRoutine);
        }
    }

    IEnumerator BulletSpawnRoutine()
    {
        while (true)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(repeatTime);
        }
    }
}
