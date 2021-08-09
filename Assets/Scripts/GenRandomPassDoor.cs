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

    private int[] lv1;

    // Start is called before the first frame update
    void Start()
    {
        //lv1 = GetArray(lv1Doors.Length / 2);
        //int[] lv1D = new int[lv1.Length * 2];
        //for (int i = 0; i < lv1.Length; i++)
        //{
        //    lv1D[i * 2] = lv1[i];
        //    lv1D[i * 2 + 1] = lv1[i];
        //}

        //for (int i = 0; i < lv1D.Length; i++)
        //{
        //    if (lv1D[0] == 0)
        //    {
        //        Destroy(lv1Doors[i].GetComponent<Rigidbody>());
        //    }
        //}

        //for (int i = 0; i < lv2Doors.Length; i = i + 2)
        //{
        //    if (Random.Range(0, 3) != 1)
        //    {
        //        Destroy(lv2Doors[i].GetComponent<Rigidbody>());
        //        Destroy(lv2Doors[i + 1].GetComponent<Rigidbody>());
        //    }
        //}

        //for (int i = 0; i < lv3Doors.Length; i = i + 2)
        //{
        //    if (Random.Range(0, 3) != 1)
        //    {
        //        Destroy(lv3Doors[i].GetComponent<Rigidbody>());
        //        Destroy(lv3Doors[i + 1].GetComponent<Rigidbody>());
        //    }
        //}

        //for (int i = 0; i < lv4Doors.Length; i = i + 2)
        //{
        //    if (Random.Range(0, 3) != 1)
        //    {
        //        Destroy(lv4Doors[i].GetComponent<Rigidbody>());
        //        Destroy(lv4Doors[i + 1].GetComponent<Rigidbody>());
        //    }
        //}

        //for (int i = 0; i < lv5Doors.Length; i = i + 2)
        //{
        //    if (Random.Range(0, 3) != 1)
        //    {
        //        Destroy(lv5Doors[i].GetComponent<Rigidbody>());
        //        Destroy(lv5Doors[i + 1].GetComponent<Rigidbody>());
        //    }
        //}

        //for (int i = 0; i < lv6Doors.Length; i = i + 2)
        //{
        //    if (Random.Range(0, 3) != 1)
        //    {
        //        Destroy(lv6Doors[i].GetComponent<Rigidbody>());
        //        Destroy(lv6Doors[i + 1].GetComponent<Rigidbody>());
        //    }
        //}

        //for (int i = 0; i < lv7Doors.Length; i = i + 2)
        //{
        //    if (Random.Range(0, 3) != 1)
        //    {
        //        Destroy(lv7Doors[i].GetComponent<Rigidbody>());
        //        Destroy(lv7Doors[i + 1].GetComponent<Rigidbody>());
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //int[] GetArray(int number)
    //{
    //    int[] arr = new int[number];
    //    while (true)
    //    {            
    //        foreach (int i in arr)
    //        {
    //            arr[i] = Random.Range(0, 2); //0:门关闭 1：门开启
    //        }

    //        int count = 0; //统计开门数量

    //        foreach (int i in arr)
    //        {
    //            if (arr[i] == 1)
    //            {
    //                count++;
    //            }
    //        }

    //        if (count == 2)
    //        {
    //            break;
    //        }
    //    }

    //    return arr;
    //}

}
