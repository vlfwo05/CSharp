using UnityEngine;

public class VariableSamevalue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // a,b,c �� �ʱ�ȭ :
        // ����� ���� �������� ���� ���¿��� ó������ ���� �����Ҷ� �ʱ�ȭ ����Ѵ�
        int a, b, c;
        //a = 10;
        //b = 10;
        //c = 10;
        a = b = c = 10;

        Debug.Log(a + "," + b + "," + c);

    }
}
    