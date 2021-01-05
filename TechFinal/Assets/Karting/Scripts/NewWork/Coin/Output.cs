using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Output : MonoBehaviour
{
    // Start is called before the first frame update
    public TMPro.TextMeshProUGUI TextMeshPro;
    //public Text m_text;
    void Start()
    {
        CheckCoinFile();
        int sum = ReaderJsonCoin();
        Debug.Log(PlayerPrefs.GetInt("Coin"));
        //RecordCoin(sum);

        TextMeshPro.text = "Welcome to the Karting World!\n " +
            "Total Coins :" + sum.ToString();

    }


    public void CheckCoinFile()
    {
        if (File.Exists(Application.persistentDataPath + "/Coin.txt"))
            Debug.Log("已有硬币文件");
        else
        {
            File.Create(Application.persistentDataPath + "/Coin.txt").Dispose();
            //File.Open(Application.persistentDataPath + "/Coin.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(Application.persistentDataPath + "/Coin.txt");//写入数据流
            sw.Write("0");
            sw.Close();
        }
        Debug.Log(Application.persistentDataPath);//路径根目录
    }

    private int ReaderJsonCoin()
    {
        //StreamReader sr = new StreamReader(Application.dataPath + "/Resources/RankingList.txt");//发布之后还需自己创建RankingList.txt文档复制进Resource文件夹内，不方便，且易被更改。
        StreamReader sr = new StreamReader(Application.persistentDataPath + "/Coin.txt");
        //Debug.Log(sr);
        string nextLine;
        nextLine = sr.ReadLine();
        int sum = int.Parse(nextLine);
        //int sum = JsonUtility.FromJson<int>(nextLine);
        sr.Close();
        return sum;
    }

    private void RecordCoin(int sum)
    {
        StreamWriter sw = new StreamWriter(Application.persistentDataPath + "/Coin.txt");//写入数据流

        sw.Write(sum.ToString());

        sw.Close();//写入结束

    }
}