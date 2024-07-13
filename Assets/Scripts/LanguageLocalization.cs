using TMPro;
using UnityEngine;

public class LanguageLocalization : MonoBehaviour
{
    [SerializeField] string _en;
    [SerializeField] string _ru;

    private void Start()
    {
        if (PlayerPrefs.GetString("language") == "en")
        {
            GetComponent<TMP_Text>().text = _en;
        } else if (PlayerPrefs.GetString("language") == "ru")
        {
            GetComponent<TMP_Text>().text = _ru;
        } else
        {
            GetComponent<TMP_Text>().text = _en;
        }
    }
}