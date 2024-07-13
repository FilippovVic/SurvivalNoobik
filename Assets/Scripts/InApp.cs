using System.Runtime.InteropServices;
using UnityEngine;

public class InApp : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void BuyHoodie();

    [DllImport("__Internal")]
    private static extern void BuyAnime();

    [DllImport("__Internal")]
    private static extern void BuyCrown();

    [DllImport("__Internal")]
    private static extern void CheckPayments();

    [SerializeField] private GameObject _payButton10;
    [SerializeField] private GameObject _payButton11;
    [SerializeField] private GameObject _payButton12;

    [SerializeField] private GameObject _chooseButton10;
    [SerializeField] private GameObject _chooseButton11;
    [SerializeField] private GameObject _chooseButton12;

    private void Start()
    {
        CheckPayments();
    }

    public void ButtonBuyHoodie()
    {
        BuyHoodie();
    }

    public void ButtonBuyAnime()
    {
        BuyAnime();
    }

    public void ButtonBuyCrown()
    {
        BuyCrown();
    }

    public void SetHoodieTrue()
    {
        _payButton10.SetActive(false);
        _chooseButton10.SetActive(true);
        PlayerPrefs.SetString("bought10", "yes");
    }

    public void SetAnimeTrue()
    {
        _payButton11.SetActive(false);
        _chooseButton11.SetActive(true);
        PlayerPrefs.SetString("bought11", "yes");
    }

    public void SetCrownTrue()
    {
        _payButton12.SetActive(false);
        _chooseButton12.SetActive(true);
        PlayerPrefs.SetString("bought12", "yes");
    }

    public void SetHoodieFalse()
    {
        _payButton10.SetActive(true);
        _chooseButton10.SetActive(false);
        PlayerPrefs.SetString("bought10", "no");
    }

    public void SetAnimeFalse()
    {
        _payButton11.SetActive(true);
        _chooseButton11.SetActive(false);
        PlayerPrefs.SetString("bought11", "no");
    }

    public void SetCrownFalse()
    {
        _payButton12.SetActive(true);
        _chooseButton12.SetActive(false);
        PlayerPrefs.SetString("bought12", "no");
    }
}