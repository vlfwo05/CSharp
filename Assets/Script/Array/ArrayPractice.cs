using System;
using Unity.VisualScripting;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*int[,] intArray = new int[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

        for (int i = 0; i < 3; i++ )
        {
            for(int j = 0; j < 3; j++)
            {
                int result = Convert.ToInt32(i == j);
                Debug.Log($"arr[{i}, {j}] : {result}" ); 
            }
        }*/

        int[,] arr = new int[3, 3];

        for(int i = 0; i < 3; i++)
        {
            
        }
    }
}
/*
[Q]
3�� 3���� 2���� �迭�� �����
�ʱ�ȭ �ϴµ� ��� ���� �ε��� ������ 1, ��� ���� �ε����� Ʋ���� 0���� �����ϼ���
�����ϴ� ����� ���� for�� �̿��ϼ���

1, 0, 0
0, 1, 0
0, 0, 1

[���]
arr[0, 0] : 1
arr[0, 1] : 0
....
arr[2, 2] : 1

*/