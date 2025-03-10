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
3행 3열인 2차원 배열을 만들고
초기화 하는데 행과 열의 인덱스 같으면 1, 행과 열의 인덱스가 틀리면 0으로 저장하세요
저장하는 방법을 이중 for문 이용하세요

1, 0, 0
0, 1, 0
0, 0, 1

[출력]
arr[0, 0] : 1
arr[0, 1] : 0
....
arr[2, 2] : 1

*/