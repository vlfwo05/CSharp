using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 3;
        string result = "Ȧ��";
        Debug.Log($"{num} ��(��) {result} �Դϴ�");
    }
}

/*
[Q]
3, Ȧ���� ������ �����ϰ� �����Ѵ�
���ڿ� �������� �̿��ؼ� ����� ������ ���

[Output]
3��(��) Ȧ�� �Դϴ� 
 */
