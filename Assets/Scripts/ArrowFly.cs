using UnityEngine;

public class ArrowFly : MonoBehaviour
{
    [SerializeField] private float _speed;

    private GameObject _player;
    private Vector2 _direction;
    private AudioSource _arrowSound;

    private void Start()
    {
        _arrowSound = GetComponent<AudioSource>();
        if (PlayerPrefs.GetFloat("sounds", 0) == 1)
        {
            _arrowSound.Play();
        }

        _player = GameObject.FindGameObjectWithTag("PlayerBack");
        if (_player != null)
        {
            UpdateDirection();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        MoveArrow();
    }

    private void MoveArrow()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }

    private void UpdateDirection()
    {
        _direction = (_player.transform.position - transform.position).normalized;
    }
}