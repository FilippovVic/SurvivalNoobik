using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

[System.Serializable]
public class PlayerInformation
{
    public float _bestScore;
    public float _coinsCollected;
    public float _bought2;
    public float _bought3;
    public float _bought4;
    public float _bought5;
    public float _bought6;
    public float _bought7;
    public float _bought8;
    public float _bought9;
    public float _chosenSkin;
}

public class Progress : MonoBehaviour
{
    [SerializeField] private TMP_Text _playerInfoText;
    [SerializeField] private TMP_Text _coins;

    public PlayerInformation PlayerInfo;

    [DllImport("__Internal")]
    private static extern void GetDataAgain();

    [DllImport("__Internal")]
    private static extern void SaveExtern(string data);

    public void Save()
    {
        PlayerInfo._bestScore = PlayerPrefs.GetFloat("bestScore", 0);
        PlayerInfo._coinsCollected = PlayerPrefs.GetFloat("coins", 0);
        if (PlayerPrefs.GetString("bought2") == "yes")
        {
            PlayerInfo._bought2 = 1;
        }
        else
        {
            PlayerInfo._bought2 = 0;
        }
        if (PlayerPrefs.GetString("bought3") == "yes")
        {
            PlayerInfo._bought3 = 1;
        }
        else
        {
            PlayerInfo._bought3 = 0;
        }
        if (PlayerPrefs.GetString("bought4") == "yes")
        {
            PlayerInfo._bought4 = 1;
        }
        else
        {
            PlayerInfo._bought4 = 0;
        }
        if (PlayerPrefs.GetString("bought5") == "yes")
        {
            PlayerInfo._bought5 = 1;
        }
        else
        {
            PlayerInfo._bought5 = 0;
        }
        if (PlayerPrefs.GetString("bought6") == "yes")
        {
            PlayerInfo._bought6 = 1;
        }
        else
        {
            PlayerInfo._bought6 = 0;
        }
        if (PlayerPrefs.GetString("bought7") == "yes")
        {
            PlayerInfo._bought7 = 1;
        }
        else
        {
            PlayerInfo._bought7 = 0;
        }
        if (PlayerPrefs.GetString("bought8") == "yes")
        {
            PlayerInfo._bought8 = 1;
        }
        else
        {
            PlayerInfo._bought8 = 0;
        }
        if (PlayerPrefs.GetString("bought9") == "yes")
        {
            PlayerInfo._bought9 = 1;
        }
        else
        {
            PlayerInfo._bought9 = 0;
        }


        if (PlayerPrefs.GetString("skin") == "default")
        {
            PlayerInfo._chosenSkin = 0;
        }
        else if (PlayerPrefs.GetString("skin") == "dump")
        {
            PlayerInfo._chosenSkin = 1;
        }
        else if (PlayerPrefs.GetString("skin") == "marmelade")
        {
            PlayerInfo._chosenSkin = 2;
        }
        else if (PlayerPrefs.GetString("skin") == "pinguin")
        {
            PlayerInfo._chosenSkin = 3;
        }
        else if (PlayerPrefs.GetString("skin") == "suit")
        {
            PlayerInfo._chosenSkin = 4;
        }
        else if (PlayerPrefs.GetString("skin") == "girl")
        {
            PlayerInfo._chosenSkin = 5;
        }
        else if (PlayerPrefs.GetString("skin") == "robot")
        {
            PlayerInfo._chosenSkin = 6;
        }
        else if (PlayerPrefs.GetString("skin") == "prison")
        {
            PlayerInfo._chosenSkin = 7;
        }
        else if (PlayerPrefs.GetString("skin") == "pink")
        {
            PlayerInfo._chosenSkin = 8;
        }
        else if (PlayerPrefs.GetString("skin") == "hoodie")
        {
            PlayerInfo._chosenSkin = 9;
        }
        else if (PlayerPrefs.GetString("skin") == "anime")
        {
            PlayerInfo._chosenSkin = 10;
        }
        else if (PlayerPrefs.GetString("skin") == "crown")
        {
            PlayerInfo._chosenSkin = 11;
        }

        SavePlayerData();
    }

    private void SavePlayerData()
    {
        string jsonString = JsonUtility.ToJson(PlayerInfo);
        SaveExtern(jsonString);
    }

    public void SetPlayerInfo(string value)
    {
        PlayerInfo = JsonUtility.FromJson<PlayerInformation>(value);

        if (PlayerInfo._bought2 == 1)
        {
            PlayerPrefs.SetString("bought2", "yes");
        }
        else
        {
            PlayerPrefs.SetString("bought2", "no");
        }

        if (PlayerInfo._bought3 == 1)
        {
            PlayerPrefs.SetString("bought3", "yes");
        }
        else
        {
            PlayerPrefs.SetString("bought3", "no");
        }

        if (PlayerInfo._bought4 == 1)
        {
            PlayerPrefs.SetString("bought4", "yes");
        }
        else
        {
            PlayerPrefs.SetString("bought4", "no");
        }

        if (PlayerInfo._bought5 == 1)
        {
            PlayerPrefs.SetString("bought5", "yes");
        }
        else
        {
            PlayerPrefs.SetString("bought5", "no");
        }

        if (PlayerInfo._bought6 == 1)
        {
            PlayerPrefs.SetString("bought6", "yes");
        }
        else
        {
            PlayerPrefs.SetString("bought6", "no");
        }

        if (PlayerInfo._bought7 == 1)
        {
            PlayerPrefs.SetString("bought7", "yes");
        }
        else
        {
            PlayerPrefs.SetString("bought7", "no");
        }

        if (PlayerInfo._bought8 == 1)
        {
            PlayerPrefs.SetString("bought8", "yes");
        }
        else
        {
            PlayerPrefs.SetString("bought8", "no");
        }

        if (PlayerInfo._bought9 == 1)
        {
            PlayerPrefs.SetString("bought9", "yes");
        }
        else
        {
            PlayerPrefs.SetString("bought9", "no");
        }

        PlayerPrefs.SetFloat("bestScore", PlayerInfo._bestScore);
        PlayerPrefs.SetFloat("coins", PlayerInfo._coinsCollected);

        if (PlayerInfo._chosenSkin == 0)
        {
            PlayerPrefs.SetString("skin", "default");
        }
        if (PlayerInfo._chosenSkin == 1)
        {
            PlayerPrefs.SetString("skin", "dump");
        }
        if (PlayerInfo._chosenSkin == 2)
        {
            PlayerPrefs.SetString("skin", "marmelade");
        }
        if (PlayerInfo._chosenSkin == 3)
        {
            PlayerPrefs.SetString("skin", "pinguin");
        }
        if (PlayerInfo._chosenSkin == 4)
        {
            PlayerPrefs.SetString("skin", "suit");
        }
        if (PlayerInfo._chosenSkin == 5)
        {
            PlayerPrefs.SetString("skin", "girl");
        }
        if (PlayerInfo._chosenSkin == 6)
        {
            PlayerPrefs.SetString("skin", "robot");
        }
        if (PlayerInfo._chosenSkin == 7)
        {
            PlayerPrefs.SetString("skin", "prison");
        }
        if (PlayerInfo._chosenSkin == 8)
        {
            PlayerPrefs.SetString("skin", "pink");
        }
        if (PlayerInfo._chosenSkin == 9)
        {
            PlayerPrefs.SetString("skin", "hoodie");
        }
        if (PlayerInfo._chosenSkin == 10)
        {
            PlayerPrefs.SetString("skin", "anime");
        }
        if (PlayerInfo._chosenSkin == 11)
        {
            PlayerPrefs.SetString("skin", "crown");
        }

        FindObjectOfType<StartSkin>().Reload();
    }

    private void Start()
    {
        if (PlayerPrefs.GetFloat("bestScore") == 0)
        {
            try
            {
                GetDataAgain();
            }
            catch
            { }
        }
    }

    private void FixedUpdate()
    {
        _playerInfoText.text = "Лучший результат: " + PlayerPrefs.GetFloat("bestScore", 0).ToString();
        _coins.text = PlayerPrefs.GetFloat("coins", 0).ToString();
    }
}