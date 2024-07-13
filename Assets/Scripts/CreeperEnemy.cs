using UnityEngine;

public class CreeperEnemy : MonoBehaviour
{
    [SerializeField] private float _detectionRadius = 3f;
    [SerializeField] private float _moveSpeed = 1f;
    private Transform _player;
    private bool _playerDetected = false;
    private AudioSource _creeperSound;
    private Animator _animator;
    private float _distanceToPlayer;
    private GameObject _playerColliderObject;

    [SerializeField] private Sprite _creeperLeftSprite;
    [SerializeField] private Sprite _creeperRightSprite;
    [SerializeField] private Sprite _creeperWaitSprite;
    private SpriteRenderer _spriteRenderer;
    private BoxCollider2D _collider;

    private Rigidbody2D _rb;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        _creeperSound = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
        _collider = GetComponent<BoxCollider2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.sprite = _creeperWaitSprite;
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (_player != null)
        {
            _distanceToPlayer = Vector3.Distance(transform.position, _player.position);
        }

        if (_distanceToPlayer <= _detectionRadius && _playerDetected == false)
        {
            _playerDetected = true;
            _animator.SetTrigger("Triggered");
            if (PlayerPrefs.GetFloat("sounds", 0) == 1) {
                _creeperSound.Play();
            }
            Destroy(gameObject, 2.5f);
        }

        if (_player != null && _playerDetected && _player.transform.position.x <= transform.position.x)
        {
            transform.Translate(Vector2.left * _moveSpeed * Time.deltaTime);
            _collider.size = new Vector2(1.6f, _collider.size.y);
            _collider.offset = new Vector2(0f, 0f);
            _spriteRenderer.sprite = _creeperLeftSprite;
        } 
        else if (_player != null && _playerDetected && _player.transform.position.x >= transform.position.x)
        {
            transform.Translate(Vector2.right * _moveSpeed * Time.deltaTime);
            _collider.size = new Vector2(1.6f, _collider.size.y);
            _collider.offset = new Vector2(0f, 0f);
            _spriteRenderer.sprite = _creeperRightSprite;
        }

        if (_rb.velocity.y < -0.5)
        {
            _playerColliderObject = null;
        }
    }

    private void OnDestroy()
    {
        if (_playerColliderObject != null)
        {
            Destroy(_playerColliderObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _playerColliderObject = collision.gameObject;
        }
    }

    public void StopCreeprSound()
    {
        _creeperSound.Pause();
    }

    public void ContinueCreeperSound()
    {
        _creeperSound.UnPause();
    }
}