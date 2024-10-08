using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    
    public enum Direction
    {
        Left = -1,
        Right = 1,
        Up = 0,
        Down = -2
    }

    private float _distance = 1.0f;
    
    public void Turn(Direction direction)
    {
        if (direction == Direction.Left) 
            transform.Translate(Vector3.left * _distance);
        
        if (direction == Direction.Right)
            transform.Translate(Vector3.right * _distance);
        
        if (direction == Direction.Up)
            transform.Translate(Vector3.forward * _distance);
        
        if (direction == Direction.Down)
            transform.Translate(Vector3.back * _distance);
    }

    public void PlayerShoot()
    {
        Debug.Log("Shooting Bullet");
    }
}