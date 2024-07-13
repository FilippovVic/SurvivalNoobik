using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] private TMP_Text _soundsText;
    private AudioSource _clickSound;

    [DllImport("__Internal")]
    private static extern void Show();

    private void FixedUpdate()
    {
        if (PlayerPrefs.GetString("language") == "en")
        {
            if (PlayerPrefs.GetFloat("sounds", 0) == 1)
            {
                _soundsText.text = "Sound:on";
            }
            else
            {
                _soundsText.text = "Sound:off";
            }
        } else if (PlayerPrefs.GetString("language") == "ru")
        {
            if (PlayerPrefs.GetFloat("sounds", 0) == 1)
            {
                _soundsText.text = "Звуки:вкл";
            }
            else
            {
                _soundsText.text = "Звуки:выкл";
            }
        } else
        {
            if (PlayerPrefs.GetFloat("sounds", 0) == 1)
            {
                _soundsText.text = "Sound:on";
            }
            else
            {
                _soundsText.text = "Sound:off";
            }
        }

        _clickSound = GetComponent<AudioSource>();
    }

    public void OnSoundsButton()
    {
        if (PlayerPrefs.GetString("language") == "en")
        {
            if (PlayerPrefs.GetFloat("sounds", 0) == 1)
            {
                _soundsText.text = "Sound:off";
                PlayerPrefs.SetFloat("sounds", 0);
                Show();
            }
            else
            {
                _soundsText.text = "Sound:on";
                PlayerPrefs.SetFloat("sounds", 1);
                _clickSound.Play();
                Show();
            }
        } else if (PlayerPrefs.GetString("language") == "ru")
        {
            if (PlayerPrefs.GetFloat("sounds", 0) == 1)
            {
                _soundsText.text = "Звуки:выкл";
                PlayerPrefs.SetFloat("sounds", 0);
                Show();
            }
            else
            {
                _soundsText.text = "Звуки:вкл";
                PlayerPrefs.SetFloat("sounds", 1);
                _clickSound.Play();
                Show();
            }
        } else
        {
            if (PlayerPrefs.GetFloat("sounds", 0) == 1)
            {
                _soundsText.text = "Sound:off";
                PlayerPrefs.SetFloat("sounds", 0);
                Show();
            }
            else
            {
                _soundsText.text = "Sound:on";
                PlayerPrefs.SetFloat("sounds", 1);
                _clickSound.Play();
                Show();
            }
        }
    }

    public void SoundOnClick()
    {
        if (PlayerPrefs.GetFloat("sounds", 0) == 1)
        {
            _clickSound.Play();
        }
    }
}