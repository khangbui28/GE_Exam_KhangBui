using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] Transform gunPos;

    public int health = 100;


    [SerializeField] float speed;

    [SerializeField] GameObject bulletPb;

    private ICommand jumpCommand;

    private void Start()
    {
        jumpCommand = new JumpCommand(rb);
    }

    void Update()
    {
        float input = Input.GetAxis("Horizontal");

     
        Vector3 movement = new Vector3(input,0f,0f ) * speed * Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {

            Shoot();
        }

        if (Input.GetKey(KeyCode.Space))
        {
           jumpCommand.Execute();
        }

        rb.MovePosition(transform.position + movement);
    }

    void Shoot()
    {
        Instantiate(bulletPb, gunPos.position, gunPos.rotation);

    }

    public void OnDamage(int damage)
    {
        health -= damage;

        if (health <= 0) {

            Debug.Log("GameOver");
        }

        UIManager.Instance.UpdateHealth(health);
    }
}
