using System.Collections;
using UnityEngine;

public class BlizzardMan : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject bulletPrefab;

    private void Update()
    {
        
    }


    IEnumerator EnemyMovement()
    {


        yield return new WaitForSeconds(1);

        
    }

    private void SpawnProjectile()
    {

    }
}
