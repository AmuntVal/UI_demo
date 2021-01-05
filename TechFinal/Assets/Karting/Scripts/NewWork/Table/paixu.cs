using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paixu : MonoBehaviour
{
    public InputField inputField;
    public Button button;
    public GameObject PrefabShow;
    public Image ParentsShow;
    public Image ParentsShowUI;
    public string textName;


    // Start is called before the first frame update
    void Start()
    {
        textName = PlayerPrefs.GetString("ID");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
