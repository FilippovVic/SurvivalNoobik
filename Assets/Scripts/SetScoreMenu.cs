using TMPro;
using UnityEngine;

public class SetScoreMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;

    private void FixedUpdate()
    {
        if (PlayerPrefs.GetString("language") == "en")
        {
            _scoreText.text = "Highscore: " + PlayerPrefs.GetFloat("bestScore", 0).ToString();
        } else if (PlayerPrefs.GetString("language") == "ru")
        {
            _scoreText.text = "Лучший результат: " + PlayerPrefs.GetFloat("bestScore", 0).ToString();
        } else
        {
            _scoreText.text = "Highscore: " + PlayerPrefs.GetFloat("bestScore", 0).ToString();
        }
    }
}