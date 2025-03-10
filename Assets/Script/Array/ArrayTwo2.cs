using UnityEngine;

public class ArrayTwo2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
                // [1]배열 선언
           int[,] intArray;

           // [2] 배열 요소수(크기) 생성
           intArray = new int[2, 3];

           //[3] 배열 초기화
           //0번행
           intArray[0, 0] = 1;
           intArray[0, 1] = 2;
           intArray[0, 2] = 3;
           //1번행
           intArray[1, 0] = 4;
           intArray[1, 1] = 5;
           intArray[1, 2] = 6;
         */
        //2차원 배열 선언, 요소수 생성, 초기화   
        //int[,] intArray = new int[2, 3] { {1, 2, 3 }, {4, 5, 6 } };    = 1가지

        //2차원 배열 선언, 요소수 생성(생략), 초기화   
        //int[,] intArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };    = 2가지
        int[,] intArray = { { 1, 2, 3 }, { 4, 5, 6 } };     // = 3가지

        //배열의 길이
        Debug.Log($"배열의 길이: {intArray.Length}");    //6

        //출력
        for(int i = 0; i < intArray.GetLength(0); i++)
        {
            for(int j = 0; j < intArray.GetLength(1); j++)
            {
                Debug.Log(intArray[i, j]);
            }
        }


    }
}