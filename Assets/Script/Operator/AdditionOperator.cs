using UnityEngine;

// + : ���ϱ� ������ �߰� ���
public class AdditionOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hellow" + " World!!!");  //���ڿ� ���ϱ�
        Debug.Log("Hi" + " " + "Everyone");  

        Debug.Log("123" + "456");   //123456    ���ڿ� + ���ڿ� => ���ڿ�
        Debug.Log("123" + 456);     //123456    ���ڿ� + ���� => ���ڿ�

        Debug.Log(123 + "456" + 789 + 890); //1234567890    //���� + ���ڿ� + ���� + ���� => ���ڿ�
        Debug.Log(123 + 456);               //579     //���� + ���� => ����

        Debug.Log("123" + true);               //1231   //���ڿ� + bool�� => ���ڿ�

        //Debug.Log("123" - 456);    //���ڿ����� ������ ������ ����� ����
    }
}
