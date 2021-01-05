using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour
{
    //此脚本应挂载在玩家身上
    //设置一个bool值
    bool isMagnet = false;
    public float speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //游戏对象向前移动的逻辑
        transform.Translate(transform.forward * speed * Time.deltaTime);
        //判断条件//碰撞器触发变为true
        if (isMagnet)
        {
            //利用球形检测（球心坐标，半径）
            //返回值类型为碰撞器Collider类型
            Collider[] cols = Physics.OverlapSphere(transform.position, 10);
            foreach (var item in cols)
            {
                //找到标签为Coin的对象
                if (item.gameObject.CompareTag("Coin"))
                {
                    //注：获取当前对象的CoinMove自定义组件中的公共变量设为true
                    item.GetComponent<CoinMove>().isMove = true;
                }
            }
        }



    }
    void OnTriggerEnter(Collider other)
    {
        //触发器//碰到标签为Magnet的对象
        if (other.gameObject.tag == "Magnet")
        {
            //销毁碰到的对象
            Destroy(other.gameObject);
            //同时把isMagnet设置为true
            isMagnet = true;
        }
    }
}