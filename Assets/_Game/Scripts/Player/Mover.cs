using UnityEngine;

public class Mover
{
    private float _speed;
    private Rigidbody _mover;

    public Mover(Rigidbody mover, float speed)
    {
        _mover = mover;
        _speed = speed;
    }

    public void Move(Vector3 direction)
    {
        _mover.velocity = direction * _speed;
    }
}
