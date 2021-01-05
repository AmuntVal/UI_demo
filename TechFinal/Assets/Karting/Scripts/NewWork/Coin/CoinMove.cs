using UnityEngine;
using System.Collections;

public class CoinMove : MonoBehaviour
{
    //此脚本应挂载在金币身上
    //传入玩家

    public AudioSource m_Audio;
    public Transform target;
    //公共变量
    public bool isMove = false;


    private void Start()
    {
        m_Audio = this.transform.parent.GetComponentInChildren<AudioSource>();
    }
    void Update()
    {
        //当前组件被获取到满足条件后isMove变为true
        //Debug.Log(PlayerPrefs.GetInt("Coin"));
        if (isMove)
        {
            //使用线性插值让物体有一个平缓运动//向玩家移动
            transform.position = Vector3.Lerp(transform.position, target.position, 0.0002f);
        }
        //Debug.Log((this.transform.position - target.position).sqrMagnitude);

        if((this.transform.position - target.position).sqrMagnitude < 20.0f)
        {
            m_Audio.Play();
            PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") + 1);
            Debug.Log("Collected!");
            //Debug.Log(PlayerPrefs.GetInt("Coin").ToString());
            Destroy(gameObject);
        }
    }
}
