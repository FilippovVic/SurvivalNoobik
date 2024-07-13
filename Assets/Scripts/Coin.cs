using System.Collections;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private AudioSource _coinSound;

    private void Start()
    {
        _coinSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (PlayerPrefs.GetFloat("sounds", 0) == 1)
            {
                _coinSound.Play();
                gameObject.transform.parent.GetChild(0).gameObject.SetActive(false);
                gameObject.GetComponent<Collider2D>().enabled = false;
                StartCoroutine(WaitSound());
            }
            else
            {
                FindObjectOfType<CoinCounter>().AddCoin();
                Destroy(gameObject.transform.parent.gameObject);
            }
        }

        if (other.CompareTag("Destroyer"))
        {
            Destroy(gameObject.transform.parent.gameObject);
        }
    }

    IEnumerator WaitSound()
    {
        while (_coinSound.isPlaying)
        {
            yield return null;
        }
        if (FindObjectOfType<CoinCounter>() != null)
        {
            FindObjectOfType<CoinCounter>().AddCoin();
        }
        Destroy(gameObject.transform.parent.gameObject);
    }
}