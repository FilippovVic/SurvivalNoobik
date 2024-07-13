using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinText;
    private float _coinCounter;

    public void AddCoin()
    {
        _coinCounter += 1.0f;
        _coinText.text = ((int)_coinCounter).ToString();
    }

    public float GetCoins()
    {
        return _coinCounter;
    }
}