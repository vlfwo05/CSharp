using UnityEngine;

public class VariableSamevalue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // a,b,c 값 초기화 :
        // 선언시 값을 대입하지 않은 상태에서 처음으로 값을 저장할때 초기화 라고한다
        int a, b, c;
        //a = 10;
        //b = 10;
        //c = 10;
        a = b = c = 10;

        Debug.Log(a + "," + b + "," + c);

    }
}
    