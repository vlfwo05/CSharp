using UnityEngine;

//�μ��� ���� ���ϴ� �Լ� �����
public class GetSumTwonumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] �� ����(3, 4)�� ���� ��ȯ���� �޾� ����ϱ�
        int result = Getsum(3, 4);
        Debug.Log(result);
    }

    //[1] �μ��� ���� ���ϴ� �Լ� ����� - �Ű�����, ��ȯ�� �̿�
    //�Ű������� ���� �������� ���� ��ȯ �ϴ� �Լ� ����

    int Getsum(int x, int y)
    {
        //int sum = x + y;
        //return sum;
        return (x + y);
    }
}
