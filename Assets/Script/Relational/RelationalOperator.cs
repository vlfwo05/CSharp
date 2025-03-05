using UnityEngine;

//RelationalOperator(관계형 연산자,비교 연산자) 
// <(작음), <=(작거나 같음), >(크다), =>(크거나 같다), ==(같음), !=(다름)
//결과 : true(참), false(거짓)
public class RelationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;
        Debug.Log(x < y);   //x가 t보다 작은가?   => true
        Debug.Log(x <= y);  //x가 t보다 작거나 같은가?   => true
        Debug.Log(x > y);   //x가 t보다 크냐?    => false
        Debug.Log(x >= y);  //x가 t보다 크거나 같으냐?   => false
        Debug.Log(x == y);  //x가 t랑 같냐? => false
        Debug.Log(x != y);  //x가 t랑 다르냐?    => true
        Debug.Log("AAA" == "aaa"); // => false???   대문자, 소문자 구별됨
    }
}
