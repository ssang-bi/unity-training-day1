using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButton : MonoBehaviour
{
    public void OnClick()
    {
        Managers.Scene.LoadScene("LobbyScene");
    }
}
