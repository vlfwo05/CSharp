using UnityEngine;

public class SqureClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Squre Ŭ������ ����(static) �޼��� GetName ȣ��
        // ���� �ż��� ȣ�� ��� : Ŭ�����̸�(Squre).�ż����̸�(GetName)       �����Լ� = static
        string name = Squre.GetName();
        Debug.Log(name);
    }
}
