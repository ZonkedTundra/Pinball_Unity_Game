using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using CodeMonkey;

public class UI_Testing : MonoBehaviour
{
    [SerializeField] private UI_InputWindow _iw;

    private void Start()
    {
        transform.Find("testButton").GetComponent<Button_UI>().ClickFunc = () =>
        {
            _iw.Show("Enter your name", "name", () => { CMDebug.TextPopupMouse("Cancel"); }, (string inputText) => { CMDebug.TextPopupMouse("Ok" + inputText); });
        };
    }
}
