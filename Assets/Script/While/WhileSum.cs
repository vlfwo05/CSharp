using UnityEngine;

// While���� �̿��ؼ� 1���� n(100)������ ���� ���ϴ� ���α׷� ����
public class WhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;    //����� �����ϴ� ����

        //[1] �ʱ��
        int i = 1;

        while(i <= n) // ���ǽ�
        {
            //�ݺ� ���๮
            sum = sum + i;


            //������
            i++;
        }

        Debug.Log($"1���� {n}������ �� : {sum}");
    }
}
