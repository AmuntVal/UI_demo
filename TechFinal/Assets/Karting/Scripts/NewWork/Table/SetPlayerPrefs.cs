using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetPlayerPrefs : MonoBehaviour
{
    public int LevelName;
    public InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        //inputField = GameObject.Find("InputField");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLv1()
    {

        PlayerPrefs.SetInt("Level", LevelName);
        if(inputField.placeholder)
        {
            PlayerPrefs.SetString("ID", "NewPlayer");
        }
        else
        {
            PlayerPrefs.SetString("ID", inputField.text);
        }

    }
}
