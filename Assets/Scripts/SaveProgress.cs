using System.Runtime.InteropServices;
using UnityEngine;

[System.Serializable]
public class PlayerInfo
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

public class SaveProgress : MonoBehaviour
{
    public PlayerInfo PlayerData;

    [DllImport("__Internal")]
    private static extern void SaveExtern(string data);

    public void Save()
    {
        PlayerData._bestScore = PlayerPrefs.GetFloat("bestScore", 0);
        PlayerData._coinsCollected = PlayerPrefs.GetFloat("coins", 0);
        if (PlayerPrefs.GetString("bought2") == "yes")
        {
            PlayerData._bought2 = 1;
        }
        else
        {
            PlayerData._bought2 = 0;
        }
        if (PlayerPrefs.GetString("bought3") == "yes")
        {
            PlayerData._bought3 = 1;
        }
        else
        {
            PlayerData._bought3 = 0;
        }
        if (PlayerPrefs.GetString("bought4") == "yes")
        {
            PlayerData._bought4 = 1;
        }
        else
        {
            PlayerData._bought4 = 0;
        }
        if (PlayerPrefs.GetString("bought5") == "yes")
        {
            PlayerData._bought5 = 1;
        }
        else
        {
            PlayerData._bought5 = 0;
        }
        if (PlayerPrefs.GetString("bought6") == "yes")
        {
            PlayerData._bought6 = 1;
        }
        else
        {
            PlayerData._bought6 = 0;
        }
        if (PlayerPrefs.GetString("bought7") == "yes")
        {
            PlayerData._bought7 = 1;
        }
        else
        {
            PlayerData._bought7 = 0;
        }
        if (PlayerPrefs.GetString("bought8") == "yes")
        {
            PlayerData._bought8 = 1;
        }
        else
        {
            PlayerData._bought8 = 0;
        }
        if (PlayerPrefs.GetString("bought9") == "yes")
        {
            PlayerData._bought9 = 1;
        }
        else
        {
            PlayerData._bought9 = 0;
        }


        if (PlayerPrefs.GetString("skin") == "default")
        {
            PlayerData._chosenSkin = 0;
        }
        else if (PlayerPrefs.GetString("skin") == "dump")
        {
            PlayerData._chosenSkin = 1;
        }
        else if (PlayerPrefs.GetString("skin") == "marmelade")
        {
            PlayerData._chosenSkin = 2;
        }
        else if (PlayerPrefs.GetString("skin") == "pinguin")
        {
            PlayerData._chosenSkin = 3;
        }
        else if (PlayerPrefs.GetString("skin") == "suit")
        {
            PlayerData._chosenSkin = 4;
        }
        else if (PlayerPrefs.GetString("skin") == "girl")
        {
            PlayerData._chosenSkin = 5;
        }
        else if (PlayerPrefs.GetString("skin") == "robot")
        {
            PlayerData._chosenSkin = 6;
        }
        else if (PlayerPrefs.GetString("skin") == "prison")
        {
            PlayerData._chosenSkin = 7;
        }
        else if (PlayerPrefs.GetString("skin") == "pink")
        {
            PlayerData._chosenSkin = 8;
        }
        else if (PlayerPrefs.GetString("skin") == "hoodie")
        {
            PlayerData._chosenSkin = 9;
        }
        else if (PlayerPrefs.GetString("skin") == "anime")
        {
            PlayerData._chosenSkin = 10;
        }
        else if (PlayerPrefs.GetString("skin") == "crown")
        {
            PlayerData._chosenSkin = 11;
        }

        SavePlayerData();
    }

    private void SavePlayerData()
    {
        string jsonString = JsonUtility.ToJson(PlayerData);
        try
        {
            SaveExtern(jsonString);
        } catch { }
    }
}