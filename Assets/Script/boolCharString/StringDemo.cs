using UnityEngine;

// string(���ڿ�) : ���ڿ� ������ ����
public class StringDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ���ڿ� ���� �����ϰ� �ʱ�ȭ
        string name = "ȫ�浿";

        //[2] ����ϱ�
        Debug.Log("�ȳ��ϼ���" + name + "�Դϴ�");

        string multiLine = @"
            �ȳ��ϼ���
            �ݰ����ϴ�
        ";

        Debug.Log(multiLine);
    }
}
