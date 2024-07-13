using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    private float _score;
    private Camera _camera;

    [DllImport("__Internal")]
    private static extern void SetScoreToLeaderBoard(int value);

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if (_camera.transform.position.y > 0)
        {
            _score = Mathf.Round(_camera.transform.position.y * 100);
            _scoreText.text = _score.ToString();
        } else
        {
            _scoreText.text = "";
        }
    }

    public float GetScore()
    {
        return _score;
    }

    public void SaveScore()
    {
        try
        {
            if (_score > PlayerPrefs.GetFloat("bestScore", 0))
            {
                PlayerPrefs.SetFloat("bestScore", _score);
                SetScoreToLeaderBoard((int)_score);
                FindObjectOfType<SaveProgress>().Save();
            }
        } catch {}
    }
}