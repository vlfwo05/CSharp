using UnityEngine;

//GetType : ������ ž�� �о����
public class GetTypeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1234;               //������ int
        double d = 3.14;            //�Ǽ��� double
        string s = "�ȳ��ϼ���";     //���ڿ�
        char c = 'A';               //����
        Debug.Log(i.GetType());
        Debug.Log(d.GetType());
        Debug.Log(s.GetType());
        Debug.Log(c.GetType());
    }
}
