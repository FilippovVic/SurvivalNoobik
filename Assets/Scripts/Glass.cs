using System.Collections;
using UnityEngine;

public class Glass : MonoBehaviour
{
    private AudioSource _glassSound;

    private void Start()
    {
        _glassSound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.transform.position.y - 0.75f > transform.position.y) {
                if (PlayerPrefs.GetFloat("sounds", 0) == 1)
                {
                    _glassSound.Play();
                }
                StartCoroutine(WaitSound());
            }
        }
    }

    IEnumerator WaitSound()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
    }
}