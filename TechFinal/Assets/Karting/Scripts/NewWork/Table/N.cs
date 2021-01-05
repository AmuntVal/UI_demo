using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class N : MonoBehaviour
{
    public InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        //添加监听事件
        transform.GetComponent<InputField>().onValueChanged.AddListener(Change);
        transform.GetComponent<InputField>().onEndEdit.AddListener(End);
    }

    void Change(string str)
    {
        Debug.Log("正在输入：" + str);
    }

    void End(string str)
    {
        Debug.Log("输入结果为" + str);
    }


}

