using UnityEngine;

// Variable(����) : ���α׷����� ����ϴ� �����͸� ��Ƴ��� �׸�
public class VariablNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ���� �����(����)
        int i; // i �̸����� (������)���� �����

        //[2] ������ ���� �����ϱ�(����, �Ҵ�, �ʱ�ȭ)
        i = 1234;

        //[3] ������ ����ִ� �� ����ϱ�(����)��
        Debug.Log(i);
    }
}
