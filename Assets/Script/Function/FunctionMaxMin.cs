using UnityEngine;

public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int maxvalue = GetMax(3, 5);
        Debug.Log($"3�� 5�� ū ���� {maxvalue} �̴�");

        int minvalue = GetMin(-3, -5);
        Debug.Log($"-3�� -5�� ���� ���� {minvalue} �̴�");
    }
    int GetMax(int x, int y)
    {
        /*
        int Max;
        if (x > y)
        {
            Max = x;
        }
        else
        {
            Max = y;
        }
        return Max;              => 1��
        */

        //3�� ������
        //int Max = (x > y) ? x : y;
        //return Max;           => 2��

        //return (x > y) ? x : y;        => 3��
        
        if (x > y)
        {
            return x;
        }
        else
        {
            return y;
        }              // => 4��
    }

    int GetMin(int x, int y)
    {
        int Min;
        if (x > y)
        {
            Min = y;
        }
        else
        {
            Min = x;
        }
        return Min;
    }
}


/*
[Q]
1. �Ű������� �Է� ���� �ΰ��� ������ ū���� ��ȯ�ϴ� �Լ�
2. �Ű������� �Է¹ޤ��� �ΰ��� ������ ���� ���� ��ȯ�ϴ� �Լ�
3. 3, 5�� �Է¹޾� ū���� ����ϱ�
4. -3, -5�� �Է¹޾� �������� ����ϱ�

[output]
3�� 5�� ū ���� (��ȯ��) �̴�
-3�� -5�� ���� ���� (��ȯ��) �̴�
 */