using UnityEngine;

public class functionDescriptionn : MonoBehaviour
{
    //[1] show �ż���(�Լ�) ����, ����
    void Show()
    {
        Debug.Log("Hello World!!!");
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] show �Լ� ȣ��
        Show();     // �Ű����� X, ��ȯ�� X
    }
}
/*
Function(�Լ�) / Method(�޼���)
: �ݺ��ؼ� ����ϵ��� ������� �ϳ� �̻��� ��ɹ����� ������ �ڵ�ҷ�

-���� �Լ� : ���(C#)���� �����ϴ� �Լ�, ����Ƽ���� �����ϴ� �Լ�
-����� �Լ� : ������ �Լ�

-�Ű������� ���� �Լ�
-�Ű������� �ִ� �Լ�
-��ȯ���� 

void �Լ��̸�()
{
    //�ϳ� �̻��� ��ɹ�
    //....
}

void �Լ��̸�(�Ű�����)
{
    //�ϳ� �̻��� ��ɹ�
    //....
}

(������ Ÿ��) �Լ��̸�(�Ű�����)
{
    //�ϳ� �̻��� ��ɹ�
    //....

    returne ����(��);
}

//�Լ� ����
�Է� -> ó��(����) -> ���


//�Լ�(�ż���)
 [1] �Լ� ���� (��� ����)
 [2] �Լ� ȣ�� (��� ���)


*/