using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailController : MonoBehaviour
{
    [SerializeField] GameObject _stopPanel;
    private AudioSource _clickSound;

    private CreeperEnemy[] _allCreepers;

    [DllImport("__Internal")]
    private static extern void Show();

    private void Start()
    {
        _clickSound = GetComponent<AudioSource>();
    }

    public void OnRestartButton()
    {
        try
        {
            if (PlayerPrefs.GetFloat("sounds", 0) == 1)
            {
                _clickSound.Play();
            }
            Time.timeScale = 1f;
            StartCoroutine(WaitForSoundGame());
        }
        catch { }
    }

    public void OnMenuButton()
    {
        if (PlayerPrefs.GetFloat("sounds", 0) == 1)
        {
            _clickSound.Play();
        }
        Time.timeScale = 1f;
        StartCoroutine(WaitForSoundMenu());
    }

    public void OnPauseButton()
    {
        if (Time.timeScale == 1f)
        {
            if (PlayerPrefs.GetFloat("sounds", 0) == 1)
            {
                _clickSound.Play();
            }
            _stopPanel.SetActive(true);
            Time.timeScale = 0f;
            _allCreepers = FindObjectsOfType<CreeperEnemy>();
             foreach (CreeperEnemy creeper in _allCreepers)
            {
                creeper.StopCreeprSound();
            }
            Show();
        }
        else
        {
            if (PlayerPrefs.GetFloat("sounds", 0) == 1)
            {
                _clickSound.Play();
            }
            Time.timeScale = 1f;
            _stopPanel.SetActive(false);
            _allCreepers = FindObjectsOfType<CreeperEnemy>();
            foreach (CreeperEnemy creeper in _allCreepers)
            {
                creeper.ContinueCreeperSound();
            }
        }
    }

    IEnumerator WaitForSoundGame()
    {
        while (_clickSound.isPlaying)
        {
            yield return new WaitForEndOfFrame();
        }
        try
        {
            SceneManager.LoadScene("Game");
        } catch {}
    }

    IEnumerator WaitForSoundMenu()
    {
        while (_clickSound.isPlaying)
        {
            yield return new WaitForEndOfFrame();
        }
        SceneManager.LoadScene("Menu");
    }
}