using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] int bulletSpeed;


    private void Update()
    {
        transform.position += Time.deltaTime * Vector3.right * bulletSpeed;

        Destroy(gameObject, 7);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
