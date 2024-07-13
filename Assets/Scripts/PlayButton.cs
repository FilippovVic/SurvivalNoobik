using System.Collections;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public string _currentLang;

    [DllImport("__Internal")]
    private static extern string GetLang();

    [SerializeField] private TMP_Text _playText;
    [SerializeField] private TMP_Text _skinText;

    public void OnPlayClick()
    {
        Application.runInBackground = false;
        StartCoroutine(WaitForSound());
    }

    IEnumerator WaitForSound()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Game");
    }

    private void Awake()
    {
        _currentLang = GetLang();
        PlayerPrefs.SetString("language", _currentLang);
    }

    private void Start()
    {
        _currentLang = GetLang();
        PlayerPrefs.SetString("language", _currentLang);
        Application.runInBackground = true;
    }

    private void FixedUpdate()
    {
        if (PlayerPrefs.GetString("language") == "en")
        {
            _playText.text = "Play";
            _skinText.text = "Skins";
        } else if (PlayerPrefs.GetString("language") == "ru")
        {
            _playText.text = "Играть";
            _skinText.text = "Скины";
        } else
        {
            _playText.text = "Play";
            _skinText.text = "Skins";
        }
    }
}