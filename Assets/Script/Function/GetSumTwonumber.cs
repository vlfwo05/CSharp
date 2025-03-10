using UnityEngine;

//두수의 합을 구하는 함수 만들기
public class GetSumTwonumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] 두 저수(3, 4)의 합을 반환값을 받아 출력하기
        int result = Getsum(3, 4);
        Debug.Log(result);
    }

    //[1] 두수의 합을 구하는 함수 만들기 - 매개변수, 반환값 이용
    //매개변수로 들어온 두정수의 합을 반환 하는 함수 선언

    int Getsum(int x, int y)
    {
        //int sum = x + y;
        //return sum;
        return (x + y);
    }
}
