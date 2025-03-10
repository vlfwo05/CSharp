using UnityEngine;

// Abs(절대값)을 구하는 함수 만들기
public class FunctionAbs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = -21;
        //int abs = Abs(number);
        int abs = Mathf.Abs(number);
        Debug.Log($"-21의 절대값은 {abs}");
    }

    //매개변수로 들ㄹ어오는 정수의 절대값을 반화나하는 함수

    /*int Abs(int  num)
    {
        if(num < 0)
        {
            return -num;
        }
        else
        {
            return num;
        }*/
        //retun Abs( num < 0) ? -num : num;
    }
