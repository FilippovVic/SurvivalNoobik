using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    [SerializeField] private float _minX = -5f;
    [SerializeField] private float _maxX = 5f;

    private bool _movingRight = true;

    private void Update()
    {
        if (_movingRight)
            transform.Translate(Vector2.right * _speed * Time.deltaTime);
        else
            transform.Translate(Vector2.left * _speed * Time.deltaTime);

        if (transform.position.x >= _maxX)
        {
            _movingRight = false;
        }
        else if (transform.position.x <= _minX)
        {
            _movingRight = true;
        }
    }
}