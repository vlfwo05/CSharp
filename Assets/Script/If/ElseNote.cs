using UnityEngine;

public class ElseNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(1 != 1)
        {
            //���๮ 1
            //Debug.Log("������ ���̸� ���๮ 1�� ����");
        }
        else
        {
            //���๮ 2
            Debug.Log("������ �����̸� ���๮ 2�� ����");
        }
    }
}

/*
else ��
���� ���ǽ��� ���̸� ���๮ 1�� ���� �ϰ�, ���๮ 2�� �������� �ʴ´�
���� ���ǽ��� �����̸� ���๮ 1�� �������� �ʰ�, ���๮ 2�� �����Ѵ�

if(���ǽ�)
{
    //���๮ 1
}
esle
{
    //���๮ 2
}
    //���๮ 3

1.���ǽ��� ���̸� 
���๮ 1 -> ���๮ 3

2.���ǽ��� �����̸� 
���๮ 2 -> ���๮ 3

 
*/
