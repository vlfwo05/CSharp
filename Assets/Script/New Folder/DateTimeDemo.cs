using System;
using UnityEngine;

//������ ����ü ���
public class DateTimeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ���� �ð� ���
        Debug.Log($"�����ð�: {System.DateTime.Now}");

        //[2] ���� ��, ��, ��, ��, ��, �� ���
        Debug.Log(System.DateTime.Now.Year);
        Debug.Log(System.DateTime.Now.Day);
        Debug.Log(System.DateTime.Now.Month);
        Debug.Log(System.DateTime.Now.Hour);
        Debug.Log(System.DateTime.Now.Minute);
        Debug.Log(System.DateTime.Now.Second);

        //[3] DateTime����ü�� ������ �����ؼ� ���
        System.DateTime now = System.DateTime.Now;
        Debug.Log(now.Date);
        Debug.Log(now.ToLongTimeString());


    }
}
