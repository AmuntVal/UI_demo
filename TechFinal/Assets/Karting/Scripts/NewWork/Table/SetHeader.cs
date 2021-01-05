using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetHeader : MonoBehaviour
{
    // Start is called before the first frame update
    public TMPro.TextMeshProUGUI TextMeshPro;
    //public Text m_text;
    void Start()
    {
        CheckCoinFile();
        int sum = ReaderJsonCoin() + PlayerPrefs.GetInt("Coin");
        Debug.Log(PlayerPrefs.GetInt("Coin"));
        RecordCoin(sum);

        if(SceneManager.GetActiveScene().name == "WinScene")
        {
            TextMeshPro.text = "You WIN!" + "\n" +
            "You got " + PlayerPrefs.GetInt("Coin").ToString() + " out of THREE coins in the last level." + "\n" +
            "You have accumulated " + sum.ToString() + " coins in total!" + "\n" +
            "Lv" + PlayerPrefs.GetInt("Level").ToString() + " Ranking History";
        }
        else
        {
            TextMeshPro.text = "You LOSE!" + "\n" +
            "You got " + PlayerPrefs.GetInt("Coin").ToString() + " out of THREE coins in the last level." + "\n" +
            "You have accumulated " + sum.ToString() + " coins in total!" + "\n" +
            "Lv" + PlayerPrefs.GetInt("Level").ToString() + " Ranking History";
        }
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

    /*
    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
