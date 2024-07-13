using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsText;
    [SerializeField] private GameObject _skinsPanel;
    [SerializeField] private GameObject _button1;
    [SerializeField] private GameObject _button2;
    [SerializeField] private GameObject _button3;
    [SerializeField] private GameObject _coinsObj;
    [SerializeField] private GameObject _resultObj;
    [SerializeField] private GameObject _startSkin;

    [SerializeField] private GameObject _buyButton2;
    [SerializeField] private GameObject _buyButton3;
    [SerializeField] private GameObject _buyButton4;
    [SerializeField] private GameObject _buyButton5;
    [SerializeField] private GameObject _buyButton6;
    [SerializeField] private GameObject _buyButton7;
    [SerializeField] private GameObject _buyButton8;
    [SerializeField] private GameObject _buyButton9;
    [SerializeField] private GameObject _payButton10;
    [SerializeField] private GameObject _payButton11;
    [SerializeField] private GameObject _payButton12;

    [SerializeField] private GameObject _chooseButton1;
    [SerializeField] private GameObject _chooseButton2;
    [SerializeField] private GameObject _chooseButton3;
    [SerializeField] private GameObject _chooseButton4;
    [SerializeField] private GameObject _chooseButton5;
    [SerializeField] private GameObject _chooseButton6;
    [SerializeField] private GameObject _chooseButton7;
    [SerializeField] private GameObject _chooseButton8;
    [SerializeField] private GameObject _chooseButton9;
    [SerializeField] private GameObject _chooseButton10;
    [SerializeField] private GameObject _chooseButton11;
    [SerializeField] private GameObject _chooseButton12;

    [SerializeField] private TMP_Text _chooseButtonText1;
    [SerializeField] private TMP_Text _chooseButtonText2;
    [SerializeField] private TMP_Text _chooseButtonText3;
    [SerializeField] private TMP_Text _chooseButtonText4;
    [SerializeField] private TMP_Text _chooseButtonText5;
    [SerializeField] private TMP_Text _chooseButtonText6;
    [SerializeField] private TMP_Text _chooseButtonText7;
    [SerializeField] private TMP_Text _chooseButtonText8;
    [SerializeField] private TMP_Text _chooseButtonText9;
    [SerializeField] private TMP_Text _chooseButtonText10;
    [SerializeField] private TMP_Text _chooseButtonText11;
    [SerializeField] private TMP_Text _chooseButtonText12;

    [SerializeField] private float _coins;

    [DllImport("__Internal")]
    private static extern void Show();

    [SerializeField] private Animator _animator2;
    [SerializeField] private Animator _animator3;
    [SerializeField] private Animator _animator4;
    [SerializeField] private Animator _animator5;
    [SerializeField] private Animator _animator6;
    [SerializeField] private Animator _animator7;
    [SerializeField] private Animator _animator8;
    [SerializeField] private Animator _animator9;

    private void FixedUpdate()
    {
        _coins = PlayerPrefs.GetFloat("coins", 0);
        _coinsText.text = _coins.ToString();

        if (PlayerPrefs.GetString("bought2", "no") == "no")
        {
            _buyButton2.SetActive(true);
            _chooseButton2.SetActive(false);
        } else
        {
            _buyButton2.SetActive(false);
            _chooseButton2.SetActive(true);
        }

        if (PlayerPrefs.GetString("bought3", "no") == "no")
        {
            _buyButton3.SetActive(true);
            _chooseButton3.SetActive(false);
        }
        else
        {
            _buyButton3.SetActive(false);
            _chooseButton3.SetActive(true);
        }

        if (PlayerPrefs.GetString("bought4", "no") == "no")
        {
            _buyButton4.SetActive(true);
            _chooseButton4.SetActive(false);
        }
        else
        {
            _buyButton4.SetActive(false);
            _chooseButton4.SetActive(true);
        }

        if (PlayerPrefs.GetString("bought5", "no") == "no")
        {
            _buyButton5.SetActive(true);
            _chooseButton5.SetActive(false);
        }
        else
        {
            _buyButton5.SetActive(false);
            _chooseButton5.SetActive(true);
        }

        if (PlayerPrefs.GetString("bought6", "no") == "no")
        {
            _buyButton6.SetActive(true);
            _chooseButton6.SetActive(false);
        }
        else
        {
            _buyButton6.SetActive(false);
            _chooseButton6.SetActive(true);
        }

        if (PlayerPrefs.GetString("bought7", "no") == "no")
        {
            _buyButton7.SetActive(true);
            _chooseButton7.SetActive(false);
        }
        else
        {
            _buyButton7.SetActive(false);
            _chooseButton7.SetActive(true);
        }

        if (PlayerPrefs.GetString("bought8", "no") == "no")
        {
            _buyButton8.SetActive(true);
            _chooseButton8.SetActive(false);
        }
        else
        {
            _buyButton8.SetActive(false);
            _chooseButton8.SetActive(true);
        }

        if (PlayerPrefs.GetString("bought9", "no") == "no")
        {
            _buyButton9.SetActive(true);
            _chooseButton9.SetActive(false);
        }
        else
        {
            _buyButton9.SetActive(false);
            _chooseButton9.SetActive(true);
        }

        if (PlayerPrefs.GetString("bought10", "no") == "no")
        {
            _payButton10.SetActive(true);
            _chooseButton10.SetActive(false);
        }
        else
        {
            _payButton10.SetActive(false);
            _chooseButton10.SetActive(true);
        }

        if (PlayerPrefs.GetString("bought11", "no") == "no")
        {
            _payButton11.SetActive(true);
            _chooseButton11.SetActive(false);
        }
        else
        {
            _payButton11.SetActive(false);
            _chooseButton11.SetActive(true);
        }

        if (PlayerPrefs.GetString("bought12", "no") == "no")
        {
            _payButton12.SetActive(true);
            _chooseButton12.SetActive(false);
        }
        else
        {
            _payButton12.SetActive(false);
            _chooseButton12.SetActive(true);
        }

        if (PlayerPrefs.GetString("skin", "default") == "default")
        {
            if (PlayerPrefs.GetString("language") == "en")
            {
                _chooseButtonText1.text = "Selected";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            } else if (PlayerPrefs.GetString("language") == "ru")
            {
                _chooseButtonText1.text = "Активен";
                _chooseButtonText2.text = "Выбрать";
                _chooseButtonText3.text = "Выбрать";
                _chooseButtonText4.text = "Выбрать";
                _chooseButtonText5.text = "Выбрать";
                _chooseButtonText6.text = "Выбрать";
                _chooseButtonText7.text = "Выбрать";
                _chooseButtonText8.text = "Выбрать";
                _chooseButtonText9.text = "Выбрать";
                _chooseButtonText10.text = "Выбрать";
                _chooseButtonText11.text = "Выбрать";
                _chooseButtonText12.text = "Выбрать";
            } else
            {
                _chooseButtonText1.text = "Selected";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
        } 
        else if (PlayerPrefs.GetString("skin", "default") == "dump")
        {
            if (PlayerPrefs.GetString("language") == "en")
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Selected";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
            else if (PlayerPrefs.GetString("language") == "ru")
            {
                _chooseButtonText1.text = "Выбрать";
                _chooseButtonText2.text = "Активен";
                _chooseButtonText3.text = "Выбрать";
                _chooseButtonText4.text = "Выбрать";
                _chooseButtonText5.text = "Выбрать";
                _chooseButtonText6.text = "Выбрать";
                _chooseButtonText7.text = "Выбрать";
                _chooseButtonText8.text = "Выбрать";
                _chooseButtonText9.text = "Выбрать";
                _chooseButtonText10.text = "Выбрать";
                _chooseButtonText11.text = "Выбрать";
                _chooseButtonText12.text = "Выбрать";
            }
            else
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Selected";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
        } 
        else if (PlayerPrefs.GetString("skin", "default") == "marmelade")
        {
            if (PlayerPrefs.GetString("language") == "en")
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Selected";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
            else if (PlayerPrefs.GetString("language") == "ru")
            {
                _chooseButtonText1.text = "Выбрать";
                _chooseButtonText2.text = "Выбрать";
                _chooseButtonText3.text = "Активен";
                _chooseButtonText4.text = "Выбрать";
                _chooseButtonText5.text = "Выбрать";
                _chooseButtonText6.text = "Выбрать";
                _chooseButtonText7.text = "Выбрать";
                _chooseButtonText8.text = "Выбрать";
                _chooseButtonText9.text = "Выбрать";
                _chooseButtonText10.text = "Выбрать";
                _chooseButtonText11.text = "Выбрать";
                _chooseButtonText12.text = "Выбрать";
            }
            else
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Selected";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
        } 
        else if (PlayerPrefs.GetString("skin", "default") == "pinguin")
        {
            if (PlayerPrefs.GetString("language") == "en")
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Selected";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
            else if (PlayerPrefs.GetString("language") == "ru")
            {
                _chooseButtonText1.text = "Выбрать";
                _chooseButtonText2.text = "Выбрать";
                _chooseButtonText3.text = "Выбрать";
                _chooseButtonText4.text = "Активен";
                _chooseButtonText5.text = "Выбрать";
                _chooseButtonText6.text = "Выбрать";
                _chooseButtonText7.text = "Выбрать";
                _chooseButtonText8.text = "Выбрать";
                _chooseButtonText9.text = "Выбрать";
                _chooseButtonText10.text = "Выбрать";
                _chooseButtonText11.text = "Выбрать";
                _chooseButtonText12.text = "Выбрать";
            }
            else
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Selected";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
        } 
        else if (PlayerPrefs.GetString("skin", "default") == "suit")
        {
            if (PlayerPrefs.GetString("language") == "en")
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Selected";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
            else if (PlayerPrefs.GetString("language") == "ru")
            {
                _chooseButtonText1.text = "Выбрать";
                _chooseButtonText2.text = "Выбрать";
                _chooseButtonText3.text = "Выбрать";
                _chooseButtonText4.text = "Выбрать";
                _chooseButtonText5.text = "Активен";
                _chooseButtonText6.text = "Выбрать";
                _chooseButtonText7.text = "Выбрать";
                _chooseButtonText8.text = "Выбрать";
                _chooseButtonText9.text = "Выбрать";
                _chooseButtonText10.text = "Выбрать";
                _chooseButtonText11.text = "Выбрать";
                _chooseButtonText12.text = "Выбрать";
            }
            else
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Selected";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
        }
        else if (PlayerPrefs.GetString("skin", "default") == "girl")
        {
            if (PlayerPrefs.GetString("language") == "en")
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Selected";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
            else if (PlayerPrefs.GetString("language") == "ru")
            {
                _chooseButtonText1.text = "Выбрать";
                _chooseButtonText2.text = "Выбрать";
                _chooseButtonText3.text = "Выбрать";
                _chooseButtonText4.text = "Выбрать";
                _chooseButtonText5.text = "Выбрать";
                _chooseButtonText6.text = "Активен";
                _chooseButtonText7.text = "Выбрать";
                _chooseButtonText8.text = "Выбрать";
                _chooseButtonText9.text = "Выбрать";
                _chooseButtonText10.text = "Выбрать";
                _chooseButtonText11.text = "Выбрать";
                _chooseButtonText12.text = "Выбрать";
            }
            else
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Selected";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
        } 
        else if (PlayerPrefs.GetString("skin", "default") == "robot")
        {
            if (PlayerPrefs.GetString("language") == "en")
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Selected";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
            else if (PlayerPrefs.GetString("language") == "ru")
            {
                _chooseButtonText1.text = "Выбрать";
                _chooseButtonText2.text = "Выбрать";
                _chooseButtonText3.text = "Выбрать";
                _chooseButtonText4.text = "Выбрать";
                _chooseButtonText5.text = "Выбрать";
                _chooseButtonText6.text = "Выбрать";
                _chooseButtonText7.text = "Активен";
                _chooseButtonText8.text = "Выбрать";
                _chooseButtonText9.text = "Выбрать";
                _chooseButtonText10.text = "Выбрать";
                _chooseButtonText11.text = "Выбрать";
                _chooseButtonText12.text = "Выбрать";
            }
            else
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Selected";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
        } 
        else if (PlayerPrefs.GetString("skin", "default") == "prison")
        {
            if (PlayerPrefs.GetString("language") == "en")
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Selected";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
            else if (PlayerPrefs.GetString("language") == "ru")
            {
                _chooseButtonText1.text = "Выбрать";
                _chooseButtonText2.text = "Выбрать";
                _chooseButtonText3.text = "Выбрать";
                _chooseButtonText4.text = "Выбрать";
                _chooseButtonText5.text = "Выбрать";
                _chooseButtonText6.text = "Выбрать";
                _chooseButtonText7.text = "Выбрать";
                _chooseButtonText8.text = "Активен";
                _chooseButtonText9.text = "Выбрать";
                _chooseButtonText10.text = "Выбрать";
                _chooseButtonText11.text = "Выбрать";
                _chooseButtonText12.text = "Выбрать";
            }
            else
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Selected";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
        } 
        else if (PlayerPrefs.GetString("skin", "default") == "pink")
        {
            if (PlayerPrefs.GetString("language") == "en")
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Selected";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
            else if (PlayerPrefs.GetString("language") == "ru")
            {
                _chooseButtonText1.text = "Выбрать";
                _chooseButtonText2.text = "Выбрать";
                _chooseButtonText3.text = "Выбрать";
                _chooseButtonText4.text = "Выбрать";
                _chooseButtonText5.text = "Выбрать";
                _chooseButtonText6.text = "Выбрать";
                _chooseButtonText7.text = "Выбрать";
                _chooseButtonText8.text = "Выбрать";
                _chooseButtonText9.text = "Активен";
                _chooseButtonText10.text = "Выбрать";
                _chooseButtonText11.text = "Выбрать";
                _chooseButtonText12.text = "Выбрать";
            }
            else
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Selected";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
        } 
        else if (PlayerPrefs.GetString("skin", "default") == "hoodie")
        {
            if (PlayerPrefs.GetString("language") == "en")
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Selected";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
            else if (PlayerPrefs.GetString("language") == "ru")
            {
                _chooseButtonText1.text = "Выбрать";
                _chooseButtonText2.text = "Выбрать";
                _chooseButtonText3.text = "Выбрать";
                _chooseButtonText4.text = "Выбрать";
                _chooseButtonText5.text = "Выбрать";
                _chooseButtonText6.text = "Выбрать";
                _chooseButtonText7.text = "Выбрать";
                _chooseButtonText8.text = "Выбрать";
                _chooseButtonText9.text = "Выбрать";
                _chooseButtonText10.text = "Активен";
                _chooseButtonText11.text = "Выбрать";
                _chooseButtonText12.text = "Выбрать";
            }
            else
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Selected";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Choose";
            }
        } 
        else if (PlayerPrefs.GetString("skin", "default") == "anime")
        {
            if (PlayerPrefs.GetString("language") == "en")
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Selected";
                _chooseButtonText12.text = "Choose";
            }
            else if (PlayerPrefs.GetString("language") == "ru")
            {
                _chooseButtonText1.text = "Выбрать";
                _chooseButtonText2.text = "Выбрать";
                _chooseButtonText3.text = "Выбрать";
                _chooseButtonText4.text = "Выбрать";
                _chooseButtonText5.text = "Выбрать";
                _chooseButtonText6.text = "Выбрать";
                _chooseButtonText7.text = "Выбрать";
                _chooseButtonText8.text = "Выбрать";
                _chooseButtonText9.text = "Выбрать";
                _chooseButtonText10.text = "Выбрать";
                _chooseButtonText11.text = "Активен";
                _chooseButtonText12.text = "Выбрать";
            }
            else
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Selected";
                _chooseButtonText12.text = "Choose";
            }
        } 
        else if (PlayerPrefs.GetString("skin", "default") == "crown")
        {
            if (PlayerPrefs.GetString("language") == "en")
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Selected";
            }
            else if (PlayerPrefs.GetString("language") == "ru")
            {
                _chooseButtonText1.text = "Выбрать";
                _chooseButtonText2.text = "Выбрать";
                _chooseButtonText3.text = "Выбрать";
                _chooseButtonText4.text = "Выбрать";
                _chooseButtonText5.text = "Выбрать";
                _chooseButtonText6.text = "Выбрать";
                _chooseButtonText7.text = "Выбрать";
                _chooseButtonText8.text = "Выбрать";
                _chooseButtonText9.text = "Выбрать";
                _chooseButtonText10.text = "Выбрать";
                _chooseButtonText11.text = "Выбрать";
                _chooseButtonText12.text = "Активен";
            }
            else
            {
                _chooseButtonText1.text = "Choose";
                _chooseButtonText2.text = "Choose";
                _chooseButtonText3.text = "Choose";
                _chooseButtonText4.text = "Choose";
                _chooseButtonText5.text = "Choose";
                _chooseButtonText6.text = "Choose";
                _chooseButtonText7.text = "Choose";
                _chooseButtonText8.text = "Choose";
                _chooseButtonText9.text = "Choose";
                _chooseButtonText10.text = "Choose";
                _chooseButtonText11.text = "Choose";
                _chooseButtonText12.text = "Selected";
            }
        }
    }

    public void ActivateSkinsPanel()
    {
        _button1.SetActive(false);
        _button2.SetActive(false);
        _button3.SetActive(false);
        _coinsObj.SetActive(false);
        _resultObj.SetActive(false);
        _skinsPanel.SetActive(true);
        _startSkin.SetActive(false);
        Show();
    }

    public void DeactivateSkinsPanel()
    {
        _button1.SetActive(true);
        _button2.SetActive(true);
        _button3.SetActive(true);
        _coinsObj.SetActive(true);
        _resultObj.SetActive(true);
        _skinsPanel.SetActive(false);
        _startSkin.SetActive(true);
        Show();
    }

    public void Chosen1()
    {
        if (PlayerPrefs.GetString("language") == "en")
        {
            _chooseButtonText1.text = "Selected";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        else if (PlayerPrefs.GetString("language") == "ru")
        {
            _chooseButtonText1.text = "Активен";
            _chooseButtonText2.text = "Выбрать";
            _chooseButtonText3.text = "Выбрать";
            _chooseButtonText4.text = "Выбрать";
            _chooseButtonText5.text = "Выбрать";
            _chooseButtonText6.text = "Выбрать";
            _chooseButtonText7.text = "Выбрать";
            _chooseButtonText8.text = "Выбрать";
            _chooseButtonText9.text = "Выбрать";
            _chooseButtonText10.text = "Выбрать";
            _chooseButtonText11.text = "Выбрать";
            _chooseButtonText12.text = "Выбрать";
        }
        else
        {
            _chooseButtonText1.text = "Selected";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        PlayerPrefs.SetString("skin", "default");
        FindObjectOfType<StartSkin>().Reload();
        FindObjectOfType<Progress>().PlayerInfo._chosenSkin = 0;
        FindObjectOfType<Progress>().Save();
    }

    public void Chosen2()
    {
        if (PlayerPrefs.GetString("language") == "en")
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Selected";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        else if (PlayerPrefs.GetString("language") == "ru")
        {
            _chooseButtonText1.text = "Выбрать";
            _chooseButtonText2.text = "Активен";
            _chooseButtonText3.text = "Выбрать";
            _chooseButtonText4.text = "Выбрать";
            _chooseButtonText5.text = "Выбрать";
            _chooseButtonText6.text = "Выбрать";
            _chooseButtonText7.text = "Выбрать";
            _chooseButtonText8.text = "Выбрать";
            _chooseButtonText9.text = "Выбрать";
            _chooseButtonText10.text = "Выбрать";
            _chooseButtonText11.text = "Выбрать";
            _chooseButtonText12.text = "Выбрать";
        }
        else
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Selected";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        PlayerPrefs.SetString("skin", "dump");
        FindObjectOfType<StartSkin>().Reload();
        FindObjectOfType<Progress>().PlayerInfo._chosenSkin = 1;
        FindObjectOfType<Progress>().Save();
    }

    public void Chosen3()
    {
        if (PlayerPrefs.GetString("language") == "en")
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Selected";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        else if (PlayerPrefs.GetString("language") == "ru")
        {
            _chooseButtonText1.text = "Выбрать";
            _chooseButtonText2.text = "Выбрать";
            _chooseButtonText3.text = "Активен";
            _chooseButtonText4.text = "Выбрать";
            _chooseButtonText5.text = "Выбрать";
            _chooseButtonText6.text = "Выбрать";
            _chooseButtonText7.text = "Выбрать";
            _chooseButtonText8.text = "Выбрать";
            _chooseButtonText9.text = "Выбрать";
            _chooseButtonText10.text = "Выбрать";
            _chooseButtonText11.text = "Выбрать";
            _chooseButtonText12.text = "Выбрать";
        }
        else
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Selected";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        PlayerPrefs.SetString("skin", "marmelade");
        FindObjectOfType<StartSkin>().Reload();
        FindObjectOfType<Progress>().PlayerInfo._chosenSkin = 2;
        FindObjectOfType<Progress>().Save();
    }

    public void Chosen4()
    {
        if (PlayerPrefs.GetString("language") == "en")
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Selected";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        else if (PlayerPrefs.GetString("language") == "ru")
        {
            _chooseButtonText1.text = "Выбрать";
            _chooseButtonText2.text = "Выбрать";
            _chooseButtonText3.text = "Выбрать";
            _chooseButtonText4.text = "Активен";
            _chooseButtonText5.text = "Выбрать";
            _chooseButtonText6.text = "Выбрать";
            _chooseButtonText7.text = "Выбрать";
            _chooseButtonText8.text = "Выбрать";
            _chooseButtonText9.text = "Выбрать";
            _chooseButtonText10.text = "Выбрать";
            _chooseButtonText11.text = "Выбрать";
            _chooseButtonText12.text = "Выбрать";
        }
        else
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Selected";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        PlayerPrefs.SetString("skin", "pinguin");
        FindObjectOfType<StartSkin>().Reload();
        FindObjectOfType<Progress>().PlayerInfo._chosenSkin = 3;
        FindObjectOfType<Progress>().Save();
    }

    public void Chosen5()
    {
        if (PlayerPrefs.GetString("language") == "en")
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Selected";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        else if (PlayerPrefs.GetString("language") == "ru")
        {
            _chooseButtonText1.text = "Выбрать";
            _chooseButtonText2.text = "Выбрать";
            _chooseButtonText3.text = "Выбрать";
            _chooseButtonText4.text = "Выбрать";
            _chooseButtonText5.text = "Активен";
            _chooseButtonText6.text = "Выбрать";
            _chooseButtonText7.text = "Выбрать";
            _chooseButtonText8.text = "Выбрать";
            _chooseButtonText9.text = "Выбрать";
            _chooseButtonText10.text = "Выбрать";
            _chooseButtonText11.text = "Выбрать";
            _chooseButtonText12.text = "Выбрать";
        }
        else
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Selected";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        PlayerPrefs.SetString("skin", "suit");
        FindObjectOfType<StartSkin>().Reload();
        FindObjectOfType<Progress>().PlayerInfo._chosenSkin = 4;
        FindObjectOfType<Progress>().Save();
    }

    public void Chosen6()
    {
        if (PlayerPrefs.GetString("language") == "en")
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Selected";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        else if (PlayerPrefs.GetString("language") == "ru")
        {
            _chooseButtonText1.text = "Выбрать";
            _chooseButtonText2.text = "Выбрать";
            _chooseButtonText3.text = "Выбрать";
            _chooseButtonText4.text = "Выбрать";
            _chooseButtonText5.text = "Выбрать";
            _chooseButtonText6.text = "Активен";
            _chooseButtonText7.text = "Выбрать";
            _chooseButtonText8.text = "Выбрать";
            _chooseButtonText9.text = "Выбрать";
            _chooseButtonText10.text = "Выбрать";
            _chooseButtonText11.text = "Выбрать";
            _chooseButtonText12.text = "Выбрать";
        }
        else
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Selected";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        PlayerPrefs.SetString("skin", "girl");
        FindObjectOfType<StartSkin>().Reload();
        FindObjectOfType<Progress>().PlayerInfo._chosenSkin = 5;
        FindObjectOfType<Progress>().Save();
    }

    public void Chosen7()
    {
        if (PlayerPrefs.GetString("language") == "en")
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Selected";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        else if (PlayerPrefs.GetString("language") == "ru")
        {
            _chooseButtonText1.text = "Выбрать";
            _chooseButtonText2.text = "Выбрать";
            _chooseButtonText3.text = "Выбрать";
            _chooseButtonText4.text = "Выбрать";
            _chooseButtonText5.text = "Выбрать";
            _chooseButtonText6.text = "Выбрать";
            _chooseButtonText7.text = "Активен";
            _chooseButtonText8.text = "Выбрать";
            _chooseButtonText9.text = "Выбрать";
            _chooseButtonText10.text = "Выбрать";
            _chooseButtonText11.text = "Выбрать";
            _chooseButtonText12.text = "Выбрать";
        }
        else
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Selected";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        PlayerPrefs.SetString("skin", "robot");
        FindObjectOfType<StartSkin>().Reload();
        FindObjectOfType<Progress>().PlayerInfo._chosenSkin = 6;
        FindObjectOfType<Progress>().Save();
    }

    public void Chosen8()
    {
        if (PlayerPrefs.GetString("language") == "en")
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Selected";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        else if (PlayerPrefs.GetString("language") == "ru")
        {
            _chooseButtonText1.text = "Выбрать";
            _chooseButtonText2.text = "Выбрать";
            _chooseButtonText3.text = "Выбрать";
            _chooseButtonText4.text = "Выбрать";
            _chooseButtonText5.text = "Выбрать";
            _chooseButtonText6.text = "Выбрать";
            _chooseButtonText7.text = "Выбрать";
            _chooseButtonText8.text = "Активен";
            _chooseButtonText9.text = "Выбрать";
            _chooseButtonText10.text = "Выбрать";
            _chooseButtonText11.text = "Выбрать";
            _chooseButtonText12.text = "Выбрать";
        }
        else
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Selected";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        PlayerPrefs.SetString("skin", "prison");
        FindObjectOfType<StartSkin>().Reload();
        FindObjectOfType<Progress>().PlayerInfo._chosenSkin = 7;
        FindObjectOfType<Progress>().Save();
    }

    public void Chosen9()
    {
        if (PlayerPrefs.GetString("language") == "en")
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Selected";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        else if (PlayerPrefs.GetString("language") == "ru")
        {
            _chooseButtonText1.text = "Выбрать";
            _chooseButtonText2.text = "Выбрать";
            _chooseButtonText3.text = "Выбрать";
            _chooseButtonText4.text = "Выбрать";
            _chooseButtonText5.text = "Выбрать";
            _chooseButtonText6.text = "Выбрать";
            _chooseButtonText7.text = "Выбрать";
            _chooseButtonText8.text = "Выбрать";
            _chooseButtonText9.text = "Активен";
            _chooseButtonText10.text = "Выбрать";
            _chooseButtonText11.text = "Выбрать";
            _chooseButtonText12.text = "Выбрать";
        }
        else
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Selected";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        PlayerPrefs.SetString("skin", "pink");
        FindObjectOfType<StartSkin>().Reload();
        FindObjectOfType<Progress>().PlayerInfo._chosenSkin = 8;
        FindObjectOfType<Progress>().Save();
    }

    public void Chosen10()
    {
        if (PlayerPrefs.GetString("language") == "en")
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Selected";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        else if (PlayerPrefs.GetString("language") == "ru")
        {
            _chooseButtonText1.text = "Выбрать";
            _chooseButtonText2.text = "Выбрать";
            _chooseButtonText3.text = "Выбрать";
            _chooseButtonText4.text = "Выбрать";
            _chooseButtonText5.text = "Выбрать";
            _chooseButtonText6.text = "Выбрать";
            _chooseButtonText7.text = "Выбрать";
            _chooseButtonText8.text = "Выбрать";
            _chooseButtonText9.text = "Выбрать";
            _chooseButtonText10.text = "Активен";
            _chooseButtonText11.text = "Выбрать";
            _chooseButtonText12.text = "Выбрать";
        }
        else
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Selected";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Choose";
        }
        PlayerPrefs.SetString("skin", "hoodie");
        FindObjectOfType<StartSkin>().Reload();
        FindObjectOfType<Progress>().PlayerInfo._chosenSkin = 9;
        FindObjectOfType<Progress>().Save();
    }

    public void Chosen11()
    {
        if (PlayerPrefs.GetString("language") == "en")
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Selected";
            _chooseButtonText12.text = "Choose";
        }
        else if (PlayerPrefs.GetString("language") == "ru")
        {
            _chooseButtonText1.text = "Выбрать";
            _chooseButtonText2.text = "Выбрать";
            _chooseButtonText3.text = "Выбрать";
            _chooseButtonText4.text = "Выбрать";
            _chooseButtonText5.text = "Выбрать";
            _chooseButtonText6.text = "Выбрать";
            _chooseButtonText7.text = "Выбрать";
            _chooseButtonText8.text = "Выбрать";
            _chooseButtonText9.text = "Выбрать";
            _chooseButtonText10.text = "Выбрать";
            _chooseButtonText11.text = "Активен";
            _chooseButtonText12.text = "Выбрать";
        }
        else
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Selected";
            _chooseButtonText12.text = "Choose";
        }
        PlayerPrefs.SetString("skin", "anime");
        FindObjectOfType<StartSkin>().Reload();
        FindObjectOfType<Progress>().PlayerInfo._chosenSkin = 10;
        FindObjectOfType<Progress>().Save();
    }

    public void Chosen12()
    {
        if (PlayerPrefs.GetString("language") == "en")
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Selected";
        }
        else if (PlayerPrefs.GetString("language") == "ru")
        {
            _chooseButtonText1.text = "Выбрать";
            _chooseButtonText2.text = "Выбрать";
            _chooseButtonText3.text = "Выбрать";
            _chooseButtonText4.text = "Выбрать";
            _chooseButtonText5.text = "Выбрать";
            _chooseButtonText6.text = "Выбрать";
            _chooseButtonText7.text = "Выбрать";
            _chooseButtonText8.text = "Выбрать";
            _chooseButtonText9.text = "Выбрать";
            _chooseButtonText10.text = "Выбрать";
            _chooseButtonText11.text = "Выбрать";
            _chooseButtonText12.text = "Активен";
        }
        else
        {
            _chooseButtonText1.text = "Choose";
            _chooseButtonText2.text = "Choose";
            _chooseButtonText3.text = "Choose";
            _chooseButtonText4.text = "Choose";
            _chooseButtonText5.text = "Choose";
            _chooseButtonText6.text = "Choose";
            _chooseButtonText7.text = "Choose";
            _chooseButtonText8.text = "Choose";
            _chooseButtonText9.text = "Choose";
            _chooseButtonText10.text = "Choose";
            _chooseButtonText11.text = "Choose";
            _chooseButtonText12.text = "Selected";
        }
        PlayerPrefs.SetString("skin", "crown");
        FindObjectOfType<StartSkin>().Reload();
        FindObjectOfType<Progress>().PlayerInfo._chosenSkin = 11;
        FindObjectOfType<Progress>().Save();
    }

    public void Buy2()
    {
        if (_coins >= 50f)
        {
            PlayerPrefs.SetString("bought2", "yes");
            _buyButton2.SetActive(false);
            _chooseButton2.SetActive(true);
            _coins -= 50f;
            PlayerPrefs.SetFloat("coins", _coins);
            FindObjectOfType<Progress>().PlayerInfo._coinsCollected = _coins;
            FindObjectOfType<Progress>().PlayerInfo._bought2 = 1;
            FindObjectOfType<Progress>().Save();
        } else
        {
            _animator2.SetTrigger("Denied");
        }
    }

    public void Buy3()
    {
        if (_coins >= 100f)
        {
            PlayerPrefs.SetString("bought3", "yes");
            _buyButton3.SetActive(false);
            _chooseButton3.SetActive(true);
            _coins -= 100f;
            PlayerPrefs.SetFloat("coins", _coins);
            FindObjectOfType<Progress>().PlayerInfo._coinsCollected = _coins;
            FindObjectOfType<Progress>().PlayerInfo._bought3 = 1;
            FindObjectOfType<Progress>().Save();
        }
        else
        {
            _animator3.SetTrigger("Denied");
        }
    }

    public void Buy4()
    {
        if (_coins >= 150f)
        {
            PlayerPrefs.SetString("bought4", "yes");
            _buyButton4.SetActive(false);
            _chooseButton4.SetActive(true);
            _coins -= 150f;
            PlayerPrefs.SetFloat("coins", _coins);
            FindObjectOfType<Progress>().PlayerInfo._coinsCollected = _coins;
            FindObjectOfType<Progress>().PlayerInfo._bought4 = 1;
            FindObjectOfType<Progress>().Save();
        }
        else
        {
            _animator4.SetTrigger("Denied");
        }
    }

    public void Buy5()
    {
        if (_coins >= 200f)
        {
            PlayerPrefs.SetString("bought5", "yes");
            _buyButton5.SetActive(false);
            _chooseButton5.SetActive(true);
            _coins -= 200f;
            PlayerPrefs.SetFloat("coins", _coins);
            FindObjectOfType<Progress>().PlayerInfo._coinsCollected = _coins;
            FindObjectOfType<Progress>().PlayerInfo._bought5 = 1;
            FindObjectOfType<Progress>().Save();
        }
        else
        {
            _animator5.SetTrigger("Denied");
        }
    }

    public void Buy6()
    {
        if (_coins >= 250f)
        {
            PlayerPrefs.SetString("bought6", "yes");
            _buyButton6.SetActive(false);
            _chooseButton6.SetActive(true);
            _coins -= 250f;
            PlayerPrefs.SetFloat("coins", _coins);
            FindObjectOfType<Progress>().PlayerInfo._coinsCollected = _coins;
            FindObjectOfType<Progress>().PlayerInfo._bought6 = 1;
            FindObjectOfType<Progress>().Save();
        }
        else
        {
            _animator6.SetTrigger("Denied");
        }
    }

    public void Buy7()
    {
        if (_coins >= 300f)
        {
            PlayerPrefs.SetString("bought7", "yes");
            _buyButton7.SetActive(false);
            _chooseButton7.SetActive(true);
            _coins -= 300f;
            PlayerPrefs.SetFloat("coins", _coins);
            FindObjectOfType<Progress>().PlayerInfo._coinsCollected = _coins;
            FindObjectOfType<Progress>().PlayerInfo._bought7 = 1;
            FindObjectOfType<Progress>().Save();
        }
        else
        {
            _animator7.SetTrigger("Denied");
        }
    }

    public void Buy8()
    {
        if (_coins >= 450f)
        {
            PlayerPrefs.SetString("bought8", "yes");
            _buyButton8.SetActive(false);
            _chooseButton8.SetActive(true);
            _coins -= 450f;
            PlayerPrefs.SetFloat("coins", _coins);
            FindObjectOfType<Progress>().PlayerInfo._coinsCollected = _coins;
            FindObjectOfType<Progress>().PlayerInfo._bought8 = 1;
            FindObjectOfType<Progress>().Save();
        }
        else
        {
            _animator8.SetTrigger("Denied");
        }
    }

    public void Buy9()
    {
        if (_coins >= 500f)
        {
            PlayerPrefs.SetString("bought9", "yes");
            _buyButton9.SetActive(false);
            _chooseButton9.SetActive(true);
            _coins -= 500f;
            PlayerPrefs.SetFloat("coins", _coins);
            FindObjectOfType<Progress>().PlayerInfo._coinsCollected = _coins;
            FindObjectOfType<Progress>().PlayerInfo._bought9 = 1;
            FindObjectOfType<Progress>().Save();
        }
        else
        {
            _animator9.SetTrigger("Denied");
        }
    }
}