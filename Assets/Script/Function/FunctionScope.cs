using UnityEngine;

public class FunctionScope : MonoBehaviour
{
    string message = "���� ����";   //�ʵ�, ��� ����

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowMessage();
    }

    //meesage�� ����ϴ� �Լ�
    void ShowMessage()
    {
        string msg = "���� ����";
        Debug.Log(msg);
    }

    void PrintMessage()
    {
        Debug.Log(message);
    }    
}
