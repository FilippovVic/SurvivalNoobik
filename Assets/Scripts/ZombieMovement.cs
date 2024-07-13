using System.Collections;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    [SerializeField] private float _waitTime;
    [SerializeField] private float _speed;
    [SerializeField] private float _minX;
    [SerializeField] private float _maxX;
    [SerializeField] private Sprite _zombieLeftSprite;
    [SerializeField] private Sprite _zombieRightSprite;
    [SerializeField] private Sprite _zombieWaitSprite;

    private bool _movingRight = true;
    private SpriteRenderer _spriteRenderer;
    private BoxCollider2D _collider;
    private AudioSource _zombieRoar;
    private Renderer _objectRenderer;
    private bool _enough = false;

    private void Start()
    {
        _collider = GetComponent<BoxCollider2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _zombieRoar = GetComponent<AudioSource>();
        _objectRenderer = GetComponent<Renderer>();
        StartCoroutine(MoveZombie());
    }

    private void Update()
    {
        if (IsVisibleOnScreen() && !_enough)
        {
            if (PlayerPrefs.GetFloat("sounds", 0) == 1)
            {
                _zombieRoar.Play();
                StartCoroutine(Pause());
            }
            _enough = true;
        }
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(3.7f);
        _enough = false;
    }

    private bool IsVisibleOnScreen()
    {
        if (!_objectRenderer)
            return false;

        Vector3 objectScreenPosition = Camera.main.WorldToScreenPoint(_objectRenderer.bounds.center);
        return objectScreenPosition.z > 0 &&
               objectScreenPosition.x > 0 && objectScreenPosition.x < Screen.width &&
               objectScreenPosition.y > 0 && objectScreenPosition.y < Screen.height;
    }

    private IEnumerator MoveZombie()
    {
        while (true)
        {
            if (_movingRight)
            {
                _collider.size = new Vector2(1.6f, _collider.size.y);
                _collider.offset = new Vector2(-0.2f, 0f);
                transform.Translate(Vector2.right * _speed * Time.deltaTime);
                _spriteRenderer.sprite = _zombieRightSprite;
            }
            else
            {
                _collider.size = new Vector2(1.6f, _collider.size.y);
                _collider.offset = new Vector2(-0.25f, 0f);
                transform.Translate(Vector2.left * _speed * Time.deltaTime);
                _spriteRenderer.sprite = _zombieLeftSprite;
            }

            if (transform.localPosition.x >= _maxX)
            {
                _collider.size = new Vector2(2.55f, _collider.size.y);
                _collider.offset = new Vector2(0f, 0f);
                _movingRight = false;
                _spriteRenderer.sprite = _zombieWaitSprite;
                yield return new WaitForSeconds(_waitTime);
            }
            else if (transform.localPosition.x <= _minX)
            {
                _collider.size = new Vector2(2.55f, _collider.size.y);
                _collider.offset = new Vector2(0f, 0f);
                _movingRight = true;
                _spriteRenderer.sprite = _zombieWaitSprite;
                yield return new WaitForSeconds(_waitTime);
            }
            yield return null;
        }
    }
}