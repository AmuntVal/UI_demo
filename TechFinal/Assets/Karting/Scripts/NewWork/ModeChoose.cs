using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeChoose : MonoBehaviour
{
    public int m_GameMode;
    public void SettingMode()
    {
        PlayerPrefs.SetInt("GameMode", m_GameMode);
    }
}
