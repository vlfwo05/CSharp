using UnityEngine;

// String Ŭ����, StringBuilder Ŭ������ �̿��Ͽ� ���ڿ� �ٷ��
public class StringDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���ڿ� ���� �޼��� - �빮��, �ҹ���, ��ٱ�
        string message = "Hello World";
        Debug.Log(message);

        //[1] �빮��
        Debug.Log(message.ToUpper());

        //�ҹ���
        Debug.Log(message.ToLower());

        //[3] �ٲٱ�
        //Debug.Log(message("Hell", "�ȳ��ϼ���"));

    }
}
