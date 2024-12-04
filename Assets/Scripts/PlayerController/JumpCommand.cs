using UnityEngine;
public interface ICommand
{
    public void Execute();
}


public class JumpCommand : ICommand
{
    private Rigidbody _rb;

    public JumpCommand(Rigidbody playerRb)
    {
        _rb = playerRb;
    }

    public void Execute()
    {
        Vector3 movement = new Vector3 (0.0f,10f,0.0f) * 5f * Time.deltaTime;
        
        _rb.MovePosition(_rb.transform.position + movement);
    }
}


