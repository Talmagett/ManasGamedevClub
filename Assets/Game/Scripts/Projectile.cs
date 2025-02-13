using System;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float moveSpeed;

    private void Start()
    {
        Destroy(gameObject,3f);
    }

    void Update()
    {
        transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
    }
}