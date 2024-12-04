using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlizzardMan : MonoBehaviour
{
    [SerializeField] Rigidbody rb;

    [SerializeField] Transform areaOfAttack;

    [SerializeField] private Snowflakes[] snowPrefabs;
   
    Queue<Snowflakes>[] _pool;


    private void Start()
    {
        _pool = new Queue<Snowflakes>[snowPrefabs.Length + 1];
        for (var index = 0; index < _pool.Length; index++)
        {
            _pool[index] = new Queue<Snowflakes>();
        }
    }

    IEnumerator EnemyMovement()
    {
        GetSnowFlakes();

        yield return new WaitForSeconds(5);

        GetSnowFlakes();

    }



    public void GetSnowFlakes()
    {

        int poolType = UnityEngine.Random.Range(0, snowPrefabs.Length);
        Queue<Snowflakes> pool = _pool[poolType];
        if (!pool.TryDequeue(out Snowflakes b))
        {
            b = Instantiate(snowPrefabs[poolType], areaOfAttack.position, Quaternion.identity);
            
        }
        
        b.gameObject.SetActive(true);

    }

    public void ReturnSnowflakes(GameObject snowflakes)
    {

    }
}
