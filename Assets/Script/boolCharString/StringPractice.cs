using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 3;
        string str = "Ȧ��";
        Debug.Log($"{num} ��(��) {str} �Դϴ�");
    }
}

/*
[Q]
3, Ȧ���� ������ �����ϰ� �����Ѵ�
���ڿ� �������� �̿��ؼ� ����� ������ ���

[Output]
3��(��) Ȧ�� �Դϴ� 
 */
