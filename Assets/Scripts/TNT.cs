using System.Collections;
using UnityEngine;

public class TNT : MonoBehaviour
{
    private AudioSource _boomSound;
    private GameObject _player;

    private void Start()
    {
        _boomSound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            _player = collision.gameObject;
            if (collision.gameObject.transform.position.y - 0.75f > transform.position.y) {
                if (PlayerPrefs.GetFloat("sounds", 0) == 1)
                {
                    _boomSound.Play();
                }
                StartCoroutine(WaitDeath());
            }
        }
    }

    IEnumerator WaitDeath()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(_player);
        Destroy(gameObject);
    }
}