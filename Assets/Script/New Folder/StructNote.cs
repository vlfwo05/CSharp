using UnityEngine;

// �� ���� �����͸� �����ϴ� ����ü
//[1] ����ü ����, ����
struct BusinessCard
{
    public string name;     //�� �̸�
    public int age;         //�� ����
    public string address;  //�� �ּ�
}

public class StructNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] ����ü ������ ���� ����
        BusinessCard myCard;

        //[3] ����ü�� �����ִ� �����͵��� �ʱ�ȭ
        myCard.name = "ȫ�浿";
        myCard.age = 20;
        myCard.address = "�����";

        //[4] ����ü ���
        Debug.Log($"�̸� : {myCard.name}, ���� : {myCard.age}, �ּ� : {myCard.address}");
    }
}
