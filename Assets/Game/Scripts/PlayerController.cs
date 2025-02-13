using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float shootDelay;
    public int projectileCount;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(ShootQueue());
        }
    }

    void Shoot()
    {
        for (int i = -2; i < 3; i++)
        {
            Instantiate(projectilePrefab, transform.position+new Vector3(i,0,0), transform.rotation);
        }
    }

    IEnumerator ShootQueue()
    {
        for (int i = 0; i < projectileCount; i++)
        {
            //Instantiate(projectilePrefab, transform.position, transform.rotation);
            Shoot();
            yield return new WaitForSeconds(shootDelay);
        }
    }
}