using TMPro;
using UnityEngine;

public class Snowflakes : MonoBehaviour
{
    [SerializeField] GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        MoveToTarget();
        Destroy(gameObject, 5f);
    }

    public void MoveToTarget()
    {
        transform.position = Vector3.Lerp(transform.position, player.transform.position, Time.deltaTime) ;
    }
}
