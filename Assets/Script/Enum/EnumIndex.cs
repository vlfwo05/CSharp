using UnityEngine;

//������ ���� �������̳� ���ڿ��� ����� ����
//[1] �������� �����ϴ� ������ ����
enum Animals
{
    Rabbit,
    Dragon,
    Snake,
}

public class EnumIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //������ ���� �����ϰ� �ʱ�ȭ
        Animals animal = Animals.Dragon;
        int num = (int)animal;
        string str = animal.ToString();

        Debug.Log($"Animals.Dragon: {num}, {str}");
    }
}
