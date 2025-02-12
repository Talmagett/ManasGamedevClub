using UnityEngine;

namespace Game.Scripts
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField] private float speed;

        private void Start()
        {
            Destroy(gameObject,1);
        }

        private void Update()
        {
            transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        }
    }
}