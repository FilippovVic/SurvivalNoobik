using System.Collections;
using UnityEngine;

public class SkeletonMovement : MonoBehaviour
{
    [SerializeField] private float _waitTime;
    [SerializeField] private float _speed;
    [SerializeField] private float _minX;
    [SerializeField] private float _maxX;
    [SerializeField] private Sprite _skeletonLeftSprite;
    [SerializeField] private Sprite _skeletonRightSprite;
    [SerializeField] private Sprite _skeletonWaitSprite;
    [SerializeField] private GameObject _arrowPref;
    private float _timeBeforeShot;
    private bool _movingRight = true;
    private SpriteRenderer _spriteRenderer;
    private BoxCollider2D _collider;
    private Renderer _objectRenderer;

    private void Start()
    {
        _collider = GetComponent<BoxCollider2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _objectRenderer = GetComponent<Renderer>();
        _timeBeforeShot = Random.Range(3, 8);
        StartCoroutine(MoveSkeleton());
    }

    private void Update()
    {
        if (IsVisibleOnScreen())
        {
            _timeBeforeShot -= Time.deltaTime;
        }
        if (_timeBeforeShot < 0 && FindObjectOfType<PlayerController>() != null)
        {
            if (FindObjectOfType<PlayerController>().transform.position.y <= transform.position.y) {
                GameObject _arrow = Instantiate(_arrowPref, transform.position, Quaternion.identity);
                Destroy(_arrow, 5f);
            }
            _timeBeforeShot = Random.Range(3, 8);
        }
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

    private IEnumerator MoveSkeleton()
    {
        while (true)
        {
            if (_movingRight)
            {
                _collider.size = new Vector2(1.6f, _collider.size.y);
                _collider.offset = new Vector2(-0.2f, 0f);
                transform.Translate(Vector2.right * _speed * Time.deltaTime);
                _spriteRenderer.sprite = _skeletonRightSprite;
            }
            else
            {
                _collider.size = new Vector2(1.6f, _collider.size.y);
                _collider.offset = new Vector2(-0.25f, 0f);
                transform.Translate(Vector2.left * _speed * Time.deltaTime);
                _spriteRenderer.sprite = _skeletonLeftSprite;
            }

            if (transform.localPosition.x >= _maxX)
            {
                _collider.size = new Vector2(2.55f, _collider.size.y);
                _collider.offset = new Vector2(0f, 0f);
                _movingRight = false;
                _spriteRenderer.sprite = _skeletonWaitSprite;
                yield return new WaitForSeconds(_waitTime);
            }
            else if (transform.localPosition.x <= _minX)
            {
                _collider.size = new Vector2(2.55f, _collider.size.y);
                _collider.offset = new Vector2(0f, 0f);
                _movingRight = true;
                _spriteRenderer.sprite = _skeletonWaitSprite;
                yield return new WaitForSeconds(_waitTime);
            }
            yield return null;
        }
    }
}