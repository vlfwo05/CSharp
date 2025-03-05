using UnityEngine;

public class ElseNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(1 != 1)
        {
            //실행문 1
            //Debug.Log("조건이 참이면 실행문 1을 실행");
        }
        else
        {
            //실행문 2
            Debug.Log("조건이 거짓이면 실행문 2을 실행");
        }
    }
}

/*
else 문
만약 조건식이 참이면 실행문 1을 실행 하고, 실행문 2는 실행하지 않는다
만약 조건식이 거짓이면 실행문 1은 실행하지 않고, 실행문 2는 실행한다

if(조건식)
{
    //실행문 1
}
esle
{
    //실행문 2
}
    //실행문 3

1.조건식이 참이면 
실행문 1 -> 실행문 3

2.조건식이 거짓이면 
실행문 2 -> 실행문 3

 
*/
