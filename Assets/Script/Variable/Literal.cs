using UnityEngine;

// Literal (��)
public class Literal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ���� �����
        int num;     //������ ����
        double su;   //�Ǽ��� ����
        bool flag;   //�ο��� ����
        string str;  //���ڿ� ����
        char c;     //������ ����

        //[2] ������ ���� ����
        num = 1234;
        su = 3.14159;
        flag = true; // true, false
        str = "�ȳ��ϼ���";
        c = 'a';

        //[3] ���� ����ϱ�
        Debug.Log("num: " + num);
        Debug.Log("su: " + su);
        Debug.Log("flag: " + flag);
        Debug.Log("str: " + str);
        Debug.Log("c: " + c);
    }
}
