using UnityEngine;

//��ȯ���� �ִ� �Լ� ����� ȣ���ϱ�
public class ReturneValue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] ��ȯ���� �ִ� �Լ� ȣ��
        //��ȯ���� �޾��� ���� �����Ѱ� ��ȯ�Ǵ� �� ����
        string  returnVale = Getstring();
        Debug.Log(returnVale);
    }

    //[1] ��ȯ���� �ִ� �Լ� �����(����, ����)
    //��ȯ�� �̶�� ���ڿ�(string)�� ��ȯ�ϴ� �Լ�
    string Getstring()
    {
        return "��ȯ��(return Value";
    }

}
