using UnityEngine;

// 1차차원 배열
public class ArrayOne : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 1차원 배열 선언
        int[] intArray;

        //[2] 배열 요소수 생성 - 크기, 메모리 영역 확보
        intArray = new int[3];  //0, 1, 2

        //[3] 배열 초기화
        intArray[0] = 1;
        intArray[1] = 2;
        intArray[2] = 3;
/*
        Debug.Log($"0번째 방의 값은 :" + $"intArray[0]");
        Debug.Log($"1번째 방의 값은 :" + $"intArray[1]");
        Debug.Log($"2번째 방의 값은 :" + $"intArray[2]");
  */
        for(int i = 0; i < 3; i++)
        {
            Debug.Log($"{i}번째 방의 값은 :" + $"{intArray[i]}");
        }
    }
}
