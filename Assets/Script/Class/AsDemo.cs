using UnityEngine;

// as ������ : ~ ���� ��ȯ�ϱ�, ~ �������� ��ȭ�� �����ϸ� ��ȯ, ��ȯ�� �Ұ����ϸ� null�� ��ȯ�Ѵ�
public class AsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        object s = "�ݰ����ϴ�";
        string r1 = s as string;
        Debug.Log($"[1] {r1}");

        object i = 1234;
        string r2 = i as string;
        if(r2 == null)
        {
            Debug.Log($"[2] null �Դϴ�");
        }

        object i2 = 5678;
        if(i2 is string)
        {
            string r3 = i2 as string;
            Debug.Log($"[3] {r3}");
        }
        else
        {
            Debug.Log("[3] ��ȯ�Ұ�");    
        }
    }
}
