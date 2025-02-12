using System.Collections;
using Game.Scripts;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Projectile projectile;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private float shootDelay;
    [SerializeField] private float radius;
    [SerializeField] private int maxProjectiles;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(DeafeningBlast());
        }

        if (Input.GetKeyDown(KeyCode.P))
            DefeaningBlast();
    }

    private IEnumerator DeafeningBlast()
    {
        for (int i = 0; i < maxProjectiles; i++)
        {
            var angle = i * (360f / maxProjectiles);
            var pos = new Vector3(Mathf.Cos(Mathf.Deg2Rad * angle), 0, Mathf.Sin(Mathf.Deg2Rad * angle));
            pos *= radius;
            pos += shootPoint.localPosition;
            var rot = Quaternion.Euler(0, -angle + 90 + shootPoint.eulerAngles.y, 0);
            Instantiate(projectile, pos, rot);
            yield return new WaitForSeconds(shootDelay);
        }
    }

    private void DefeaningBlast()
    {
        for (int i = -2; i < 3; i++)
        {
            Instantiate(projectile, shootPoint.position+shootPoint.right*i, shootPoint.rotation);
        }
    }
}