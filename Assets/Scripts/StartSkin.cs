using UnityEngine;
using UnityEngine.UI;

public class StartSkin : MonoBehaviour
{
    [SerializeField] private Image _skin1;
    [SerializeField] private Image _skin2;
    [SerializeField] private Image _skin3;
    [SerializeField] private Image _skin4;
    [SerializeField] private Image _skin5;
    [SerializeField] private Image _skin6;
    [SerializeField] private Image _skin7;
    [SerializeField] private Image _skin8;
    [SerializeField] private Image _skin9;
    [SerializeField] private Image _skin10;
    [SerializeField] private Image _skin11;
    [SerializeField] private Image _skin12;

    private string _skinName;

    private void Start()
    {
        Reload();
    }

    public void Reload()
    {
        _skinName = PlayerPrefs.GetString("skin", "default");

        if (_skinName == "dump")
        {
            _skin1.enabled = false;
            _skin2.enabled = true;
            _skin3.enabled = false;
            _skin4.enabled = false;
            _skin5.enabled = false;
            _skin6.enabled = false;
            _skin7.enabled = false;
            _skin8.enabled = false;
            _skin9.enabled = false;
            _skin10.enabled = false;
            _skin11.enabled = false;
            _skin12.enabled = false;
        }
        else if (_skinName == "marmelade")
        {
            _skin1.enabled = false;
            _skin2.enabled = false;
            _skin3.enabled = true;
            _skin4.enabled = false;
            _skin5.enabled = false;
            _skin6.enabled = false;
            _skin7.enabled = false;
            _skin8.enabled = false;
            _skin9.enabled = false;
            _skin10.enabled = false;
            _skin11.enabled = false;
            _skin12.enabled = false;
        }
        else if (_skinName == "pinguin")
        {
            _skin1.enabled = false;
            _skin2.enabled = false;
            _skin3.enabled = false;
            _skin4.enabled = true;
            _skin5.enabled = false;
            _skin6.enabled = false;
            _skin7.enabled = false;
            _skin8.enabled = false;
            _skin9.enabled = false;
            _skin10.enabled = false;
            _skin11.enabled = false;
            _skin12.enabled = false;
        }
        else if (_skinName == "suit")
        {
            _skin1.enabled = false;
            _skin2.enabled = false;
            _skin3.enabled = false;
            _skin4.enabled = false;
            _skin5.enabled = true;
            _skin6.enabled = false;
            _skin7.enabled = false;
            _skin8.enabled = false;
            _skin9.enabled = false;
            _skin10.enabled = false;
            _skin11.enabled = false;
            _skin12.enabled = false;
        }
        else if (_skinName == "girl")
        {
            _skin1.enabled = false;
            _skin2.enabled = false;
            _skin3.enabled = false;
            _skin4.enabled = false;
            _skin5.enabled = false;
            _skin6.enabled = true;
            _skin7.enabled = false;
            _skin8.enabled = false;
            _skin9.enabled = false;
            _skin10.enabled = false;
            _skin11.enabled = false;
            _skin12.enabled = false;
        }
        else if (_skinName == "robot")
        {
            _skin1.enabled = false;
            _skin2.enabled = false;
            _skin3.enabled = false;
            _skin4.enabled = false;
            _skin5.enabled = false;
            _skin6.enabled = false;
            _skin7.enabled = true;
            _skin8.enabled = false;
            _skin9.enabled = false;
            _skin10.enabled = false;
            _skin11.enabled = false;
            _skin12.enabled = false;
        }
        else if (_skinName == "prison")
        {
            _skin1.enabled = false;
            _skin2.enabled = false;
            _skin3.enabled = false;
            _skin4.enabled = false;
            _skin5.enabled = false;
            _skin6.enabled = false;
            _skin7.enabled = false;
            _skin8.enabled = true;
            _skin9.enabled = false;
            _skin10.enabled = false;
            _skin11.enabled = false;
            _skin12.enabled = false;
        }
        else if (_skinName == "pink")
        {
            _skin1.enabled = false;
            _skin2.enabled = false;
            _skin3.enabled = false;
            _skin4.enabled = false;
            _skin5.enabled = false;
            _skin6.enabled = false;
            _skin7.enabled = false;
            _skin8.enabled = false;
            _skin9.enabled = true;
            _skin10.enabled = false;
            _skin11.enabled = false;
            _skin12.enabled = false;
        }
        else if (_skinName == "hoodie")
        {
            _skin1.enabled = false;
            _skin2.enabled = false;
            _skin3.enabled = false;
            _skin4.enabled = false;
            _skin5.enabled = false;
            _skin6.enabled = false;
            _skin7.enabled = false;
            _skin8.enabled = false;
            _skin9.enabled = false;
            _skin10.enabled = true;
            _skin11.enabled = false;
            _skin12.enabled = false;
        }
        else if (_skinName == "anime")
        {
            _skin1.enabled = false;
            _skin2.enabled = false;
            _skin3.enabled = false;
            _skin4.enabled = false;
            _skin5.enabled = false;
            _skin6.enabled = false;
            _skin7.enabled = false;
            _skin8.enabled = false;
            _skin9.enabled = false;
            _skin10.enabled = false;
            _skin11.enabled = true;
            _skin12.enabled = false;
        }
        else if (_skinName == "crown")
        {
            _skin1.enabled = false;
            _skin2.enabled = false;
            _skin3.enabled = false;
            _skin4.enabled = false;
            _skin5.enabled = false;
            _skin6.enabled = false;
            _skin7.enabled = false;
            _skin8.enabled = false;
            _skin9.enabled = false;
            _skin10.enabled = false;
            _skin11.enabled = false;
            _skin12.enabled = true;
        }
        else if (_skinName == "default") 
        {
            _skin1.enabled = true;
            _skin2.enabled = false;
            _skin3.enabled = false;
            _skin4.enabled = false;
            _skin5.enabled = false;
            _skin6.enabled = false;
            _skin7.enabled = false;
            _skin8.enabled = false;
            _skin9.enabled = false;
            _skin10.enabled = false;
            _skin11.enabled = false;
            _skin12.enabled = false;
        }
    }
}