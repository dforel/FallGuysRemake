using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenRandomPassDoor : MonoBehaviour
{
    public GameObject[] lv1Doors;
    public GameObject[] lv2Doors;
    public GameObject[] lv3Doors;
    public GameObject[] lv4Doors;
    public GameObject[] lv5Doors;
    public GameObject[] lv6Doors;
    public GameObject[] lv7Doors;

    public bool flag;

    private int[] lv1;
    private int[] lv2;
    private int[] lv3;
    private int[] lv4;
    private int[] lv5;
    private int[] lv6;
    private int[] lv7;

    // Start is called before the first frame update
    void Start()
    {
        if(flag)
        {
            //计算第1排门随机关门数据
            lv1 = new int[lv1Doors.Length / 2]; //构建单个门数量一半的数组
            int p1 = Random.Range(0, lv1.Length); //生成随机位置信息
            int p2 = Random.Range(0, lv1.Length);
            int p3 = Random.Range(0, lv1.Length);
            for (int i = 0; i < lv1.Length; i++)
            {
                if (i != p1 && i != p2 && i != p3)
                {
                    Destroy(lv1Doors[i * 2].GetComponent<Rigidbody>()); //让门无法通行
                    Destroy(lv1Doors[i * 2 + 1].GetComponent<Rigidbody>());
                }
            }

            //计算第2排门随机关门数据
            lv2 = new int[lv2Doors.Length / 2]; //构建单个门数量一半的数组
            p1 = Random.Range(0, lv2.Length); //生成随机位置信息
            p2 = Random.Range(0, lv2.Length);
            p3 = Random.Range(0, lv2.Length);
            for (int i = 0; i < lv2.Length; i++)
            {
                if (i != p1 && i != p2 && i != p3)
                {
                    Destroy(lv2Doors[i * 2].GetComponent<Rigidbody>()); //让门无法通行
                    Destroy(lv2Doors[i * 2 + 1].GetComponent<Rigidbody>());
                }
            }

            //计算第3排门随机关门数据
            lv3 = new int[lv3Doors.Length / 2]; //构建单个门数量一半的数组
            p1 = Random.Range(0, lv3.Length); //生成随机位置信息
            p2 = Random.Range(0, lv3.Length);
            p3 = Random.Range(0, lv3.Length);
            for (int i = 0; i < lv3.Length; i++)
            {
                if (i != p1 && i != p2 && i != p3)
                {
                    Destroy(lv3Doors[i * 2].GetComponent<Rigidbody>()); //让门无法通行
                    Destroy(lv3Doors[i * 2 + 1].GetComponent<Rigidbody>());
                }
            }

            //计算第4排门随机关门数据
            lv4 = new int[lv4Doors.Length / 2]; //构建单个门数量一半的数组
            p1 = Random.Range(0, lv4.Length); //生成随机位置信息
            p2 = Random.Range(0, lv4.Length);
            for (int i = 0; i < lv4.Length; i++)
            {
                if (i != p1 && i != p2)
                {
                    Destroy(lv4Doors[i * 2].GetComponent<Rigidbody>()); //让门无法通行
                    Destroy(lv4Doors[i * 2 + 1].GetComponent<Rigidbody>());
                }
            }

            //计算第5排门随机关门数据
            lv5 = new int[lv5Doors.Length / 2]; //构建单个门数量一半的数组
            p1 = Random.Range(0, lv5.Length); //生成随机位置信息
            p2 = Random.Range(0, lv5.Length);
            for (int i = 0; i < lv5.Length; i++)
            {
                if (i != p1 && i != p2)
                {
                    Destroy(lv5Doors[i * 2].GetComponent<Rigidbody>()); //让门无法通行
                    Destroy(lv5Doors[i * 2 + 1].GetComponent<Rigidbody>());
                }
            }

            //计算第6排门随机关门数据
            lv6 = new int[lv6Doors.Length / 2]; //构建单个门数量一半的数组
            p1 = Random.Range(0, lv6.Length); //生成随机位置信息
            p2 = Random.Range(0, lv6.Length);
            for (int i = 0; i < lv6.Length; i++)
            {
                if (i != p1 && i != p2)
                {
                    Destroy(lv6Doors[i * 2].GetComponent<Rigidbody>()); //让门无法通行
                    Destroy(lv6Doors[i * 2 + 1].GetComponent<Rigidbody>());
                }
            }

            //计算第7排门随机关门数据
            lv7 = new int[lv7Doors.Length / 2]; //构建单个门数量一半的数组
            p1 = Random.Range(0, lv7.Length); //生成随机位置信息
            for (int i = 0; i < lv7.Length; i++)
            {
                if (i != p1)
                {
                    Destroy(lv7Doors[i * 2].GetComponent<Rigidbody>()); //让门无法通行
                    Destroy(lv7Doors[i * 2 + 1].GetComponent<Rigidbody>());
                }
            }
        }        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
