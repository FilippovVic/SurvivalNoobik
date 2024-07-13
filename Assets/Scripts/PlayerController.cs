using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Sprite _leftSprite;
    [SerializeField] private Sprite _rightSprite;
    [SerializeField] private Sprite _defaultSprite;
    [SerializeField] private float _jumpHeight;
    [SerializeField] private float _minX;
    [SerializeField] private float _maxX;
    [SerializeField] private GameObject _lostPanel;
    [SerializeField] private GameObject _stopPanel;

    private float _jumpVelocity;
    private float _horizontalInput;
    private Rigidbody2D _rb;
    private SpriteRenderer _spriteRenderer;
    public bool _isGrounded = false;
    private Camera _mainCamera;
    private BoxCollider2D _collider;
    private bool _boom = false;

    [SerializeField] private string _skinName;

    [SerializeField] private Sprite _leftAnime;
    [SerializeField] private Sprite _rightAnime;
    [SerializeField] private Sprite _defaultAnime;

    [SerializeField] private Sprite _leftCrown;
    [SerializeField] private Sprite _rightCrown;
    [SerializeField] private Sprite _defaultCrown;

    [SerializeField] private Sprite _leftDump;
    [SerializeField] private Sprite _rightDump;
    [SerializeField] private Sprite _defaultDump;

    [SerializeField] private Sprite _leftGirl;
    [SerializeField] private Sprite _rightGirl;
    [SerializeField] private Sprite _defaultGirl;

    [SerializeField] private Sprite _leftHoodie;
    [SerializeField] private Sprite _rightHoodie;
    [SerializeField] private Sprite _defaultHoodie;

    [SerializeField] private Sprite _leftMarmelade;
    [SerializeField] private Sprite _rightMarmelade;
    [SerializeField] private Sprite _defaultMarmelade;

    [SerializeField] private Sprite _leftPinguin;
    [SerializeField] private Sprite _rightPinguin;
    [SerializeField] private Sprite _defaultPinguin;

    [SerializeField] private Sprite _leftPink;
    [SerializeField] private Sprite _rightPink;
    [SerializeField] private Sprite _defaultPink;

    [SerializeField] private Sprite _leftPrison;
    [SerializeField] private Sprite _rightPrison;
    [SerializeField] private Sprite _defaultPrison;

    [SerializeField] private Sprite _leftRobot;
    [SerializeField] private Sprite _rightRobot;
    [SerializeField] private Sprite _defaultRobot;

    [SerializeField] private Sprite _leftSuit;
    [SerializeField] private Sprite _rightSuit;
    [SerializeField] private Sprite _defaultSuit;

    [SerializeField] private GameObject _sCounter;
    [SerializeField] private GameObject _cCounter;
    [SerializeField] private GameObject _stopButton;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _mainCamera = Camera.main;
        _collider = GetComponent<BoxCollider2D>();

        _skinName = PlayerPrefs.GetString("skin", "default");

        if (_skinName == "anime")
        {
            _leftSprite = _leftAnime;
            _rightSprite = _rightAnime;
            _defaultSprite = _defaultAnime;
        }
        else if (_skinName == "crown")
        {
            _leftSprite = _leftCrown;
            _rightSprite = _rightCrown;
            _defaultSprite = _defaultCrown;
        }
        else if (_skinName == "dump")
        {
            _leftSprite = _leftDump;
            _rightSprite = _rightDump;
            _defaultSprite = _defaultDump;
        }
        else if (_skinName == "girl")
        {
            _leftSprite = _leftGirl;
            _rightSprite = _rightGirl;
            _defaultSprite = _defaultGirl;
        }
        else if (_skinName == "hoodie")
        {
            _leftSprite = _leftHoodie;
            _rightSprite = _rightHoodie;
            _defaultSprite = _defaultHoodie;
        }
        else if (_skinName == "marmelade")
        {
            _leftSprite = _leftMarmelade;
            _rightSprite = _rightMarmelade;
            _defaultSprite = _defaultMarmelade;
        }
        else if (_skinName == "pinguin")
        {
            _leftSprite = _leftPinguin;
            _rightSprite = _rightPinguin;
            _defaultSprite = _defaultPinguin;
        }
        else if (_skinName == "pink")
        {
            _leftSprite = _leftPink;
            _rightSprite = _rightPink;
            _defaultSprite = _defaultPink;
        }
        else if (_skinName == "prison")
        {
            _leftSprite = _leftPrison;
            _rightSprite = _rightPrison;
            _defaultSprite = _defaultPrison;
        }
        else if (_skinName == "robot")
        {
            _leftSprite = _leftRobot;
            _rightSprite = _rightRobot;
            _defaultSprite = _defaultRobot;
        }
        else if (_skinName == "suit")
        {
            _leftSprite = _leftSuit;
            _rightSprite = _rightSuit;
            _defaultSprite = _defaultSuit;
        }
        else {}
    }

    private void Update()
    {
       
        if (_isGrounded && !_boom)
        {
            _jumpVelocity = Mathf.Sqrt(2f * Mathf.Abs(Physics2D.gravity.y) * _jumpHeight);
            _rb.velocity = new Vector2(_rb.velocity.x, _jumpVelocity);
            _isGrounded = false;
        }

        _horizontalInput = GetHorizontalInput();
        if (_rb.bodyType != RigidbodyType2D.Static)
        {
            _rb.velocity = new Vector2(_horizontalInput * _moveSpeed, _rb.velocity.y);
        }

        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, _minX, _maxX);
        transform.position = clampedPosition;
        if (!_boom)
        {
            UpdatePlayerSprite(_horizontalInput);
        } else
        {
            Input.ResetInputAxes();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (collision.collider.bounds.max.y - 0.1f <= _collider.bounds.min.y)
            {
                _isGrounded = true;
                FindObjectOfType<CameraController>().MoveCameraSmoothly(collision.gameObject.transform.position);
                FindObjectOfType<DestroyerController>().MoveDestroyerSmoothly(_mainCamera.transform.position);
            }
        }

        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Skeleton"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("TNT") && collision.gameObject.transform.position.y < transform.position.y - 0.75f)
        {
            _boom = true;
            _rb.bodyType = RigidbodyType2D.Static;
        }
    }

    private float GetHorizontalInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.x < Screen.width / 2)
                return -1f;
            else
                return 1f;
        }
        return Input.GetAxis("Horizontal");
    }

    private void UpdatePlayerSprite(float horizontalInput)
    {
        if (horizontalInput > 0)
        {
            _spriteRenderer.sprite = _rightSprite;
            _collider.size = new Vector2(0.8f, _collider.size.y);
        }
        else if (horizontalInput < 0)
        {
            _spriteRenderer.sprite = _leftSprite;
            _collider.size = new Vector2(0.8f, _collider.size.y);
        }
        else
        {
            _spriteRenderer.sprite = _defaultSprite;
            _collider.size = new Vector2(1.33f, _collider.size.y);
        }
    }

    private void OnDestroy()
    {
        try
        {
            FindObjectOfType<ScoreCounter>().SaveScore();
        } catch { }

        try
        {
            if (!_lostPanel.activeSelf && !_stopPanel.activeSelf)
            {
                _lostPanel.SetActive(true);

            }
        } catch {}

        Destroy(_stopButton);
        Destroy(_sCounter);
        Destroy(_cCounter);
    }
}