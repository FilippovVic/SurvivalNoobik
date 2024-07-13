using UnityEngine;

public class Grass : MonoBehaviour
{
    private AudioSource _grassSound;

    private void Start()
    {
        _grassSound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            if (collision.gameObject.transform.position.y - 0.75f > transform.position.y) {
                if (PlayerPrefs.GetFloat("sounds", 0) == 1)
                {
                    _grassSound.Play();
                }
            }
        }
    }
}