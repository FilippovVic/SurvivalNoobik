using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class LostPanel : MonoBehaviour
{
    [SerializeField] private TMP_Text _score;
    [SerializeField] private TMP_Text _coins;
    private float _summaryCoins;

    private AudioSource _deathSound;

    private void OnEnable()
    {
        if (PlayerPrefs.GetFloat("sounds", 0) == 1)
        {
            _deathSound = GetComponent<AudioSource>();
            _deathSound.Play();
        }

        if (PlayerPrefs.GetString("language") == "en")
        {
            _score.text = "Score: " + FindObjectOfType<ScoreCounter>().GetScore().ToString();
            _coins.text = "Collected: " + FindObjectOfType<CoinCounter>().GetCoins().ToString() + " coins";
        } else if (PlayerPrefs.GetString("language") == "ru")
        {
            _score.text = "Результат: " + FindObjectOfType<ScoreCounter>().GetScore().ToString();
            _coins.text = "Собрано: " + FindObjectOfType<CoinCounter>().GetCoins().ToString() + " монет";
        } else
        {
            _score.text = "Score: " + FindObjectOfType<ScoreCounter>().GetScore().ToString();
            _coins.text = "Collected: " + FindObjectOfType<CoinCounter>().GetCoins().ToString() + " coins";
        }
        _summaryCoins = PlayerPrefs.GetFloat("coins", 0) + FindObjectOfType<CoinCounter>().GetCoins();
        PlayerPrefs.SetFloat("coins", _summaryCoins);
        FindObjectOfType<SaveProgress>().Save();
    }
}