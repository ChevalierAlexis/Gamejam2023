using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
    private Player PlayerRef;
    public TMP_Text PVText;
    public Manager ManaRef;
    public TMP_Text WaveText;
    public TMP_Text MaxWaveText;
    public GameObject AmeliorationMenu;

    void Start()
    {
        var listplayer = FindObjectsOfType<Player>();
        PlayerRef = listplayer[0];
        AmeliorationMenu.SetActive(false);
    }

    void Update()
    {
        PVText.text = PlayerRef.PV.ToString();
        WaveText.text = ManaRef.CurrentWave.ToString();
        MaxWaveText.text = ManaRef.MaxWave.ToString();
        
    }
}
