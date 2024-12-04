using UnityEngine;

public interface ICommand
{
    public void Execute();
}


public class JumpCommand : ICommand
{
    private Rigidbody _rb;
    private float _jumpHeight;

    public JumpCommand(Rigidbody playerRb, float jumpHeight)
    {
        _rb = playerRb;
        _jumpHeight = jumpHeight;
    }

    public void Execute()
    {
       
        _rb.AddForce(Vector3.up * _jumpHeight, ForceMode.Impulse);
    }
}


