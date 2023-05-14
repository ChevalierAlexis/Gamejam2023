using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
    private Player PlayerRef;
    public TMP_Text PVText;
    void Start()
    {
        var listplayer = FindObjectsOfType<Player>();
        PlayerRef = listplayer[0];
    }

    void Update()
    {
        PVText.text = PlayerRef.PV.ToString();
    }
}
