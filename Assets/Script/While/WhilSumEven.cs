using UnityEngine;

//While���� �̿��ؼ� 1���� n(100)������ ������ ¦���� ���� ���ϴ� ���α׷�
public class WhilSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;

        //[1] �ʱ��
        int i = 1;

        while (i <= n) // ���ǽ�
        {
            //�ݺ� ���๮
            if(i % 2 == 0)    //¦�� �Ǻ���
            {
                sum += i;
            }

            //������
            i++;
        }
        Debug.Log($"1����{n}������ ¦���� �� : {sum}");
    }
}
