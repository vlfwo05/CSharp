using UnityEngine;

public class ArrayTwo2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
                // [1]�迭 ����
           int[,] intArray;

           // [2] �迭 ��Ҽ�(ũ��) ����
           intArray = new int[2, 3];

           //[3] �迭 �ʱ�ȭ
           //0����
           intArray[0, 0] = 1;
           intArray[0, 1] = 2;
           intArray[0, 2] = 3;
           //1����
           intArray[1, 0] = 4;
           intArray[1, 1] = 5;
           intArray[1, 2] = 6;
         */
        //2���� �迭 ����, ��Ҽ� ����, �ʱ�ȭ   
        //int[,] intArray = new int[2, 3] { {1, 2, 3 }, {4, 5, 6 } };    = 1����

        //2���� �迭 ����, ��Ҽ� ����(����), �ʱ�ȭ   
        //int[,] intArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };    = 2����
        int[,] intArray = { { 1, 2, 3 }, { 4, 5, 6 } };     // = 3����

        //�迭�� ����
        Debug.Log($"�迭�� ����: {intArray.Length}");    //6

        //���
        for(int i = 0; i < intArray.GetLength(0); i++)
        {
            for(int j = 0; j < intArray.GetLength(1); j++)
            {
                Debug.Log(intArray[i, j]);
            }
        }


    }
}