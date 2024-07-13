using System.Collections;
using UnityEngine;

public class SandCube : MonoBehaviour
{
    [SerializeField] private float _fallSpeed;

    private Rigidbody2D _rb;
    private AudioSource _sound;
    private Animator _animator;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sound = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            if (collision.gameObject.transform.position.y - 0.75f > transform.position.y) {
                if (PlayerPrefs.GetFloat("sounds", 0) == 1) {
                    _sound.Play();
                }
                _animator.SetTrigger("SandDestroy");
                StartCoroutine(FallDown());
            }
        }
    }

    IEnumerator FallDown()
    {
        yield return new WaitForSeconds(2f);
        _rb.constraints &= ~RigidbodyConstraints2D.FreezePositionY;
        _rb.velocity = new Vector2(0, _fallSpeed);

        Destroy(gameObject, 1f);
    }
}