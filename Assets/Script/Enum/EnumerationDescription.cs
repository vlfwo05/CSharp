using UnityEngine;

//[1] �켱 ������ �����ϴ� ������ ����(����, �����)
// ����� ���� ������ ����


public class EnumerationDescription : MonoBehaviour
{
    enum Priority
    {
        High,
        Normal,
        Low,
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] ������ ���� ���� �� �ʱ�ȭ
        // ������ ������ ����Ǵ� ���� ���ǿ��� ������� ��� ���� �����ϴ�
        Priority high = Priority.High;
        Priority nomal = Priority.Normal;
        Priority low = Priority.Low;

        Debug.Log($"{high}, {nomal}, {low}");
    }
}
/*
Enumeration(������) : �ϳ��� �̸����� ���� �����ִ� ���� ���� ���� ������� ����

//����
enum (emum �̸�)
{
    �����,
    �����,
    �����,
    .....
}

 */