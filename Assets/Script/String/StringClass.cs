using UnityEngine;

// string == System.String
//����(��)�� ���� ���ϱ�: �迭�̸�.Length
public class StringClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string s1 = "hello";
        System.String s2 = "�ݰ����ϴ�";

        Debug.Log($"{s1}, {s2}");

        //����
        Debug.Log($"{s1}����:; {s1.Length},{s2}����: {s2.Length}");
    }
}
