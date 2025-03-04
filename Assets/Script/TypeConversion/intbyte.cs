using Unity.VisualScripting;
using UnityEngine;

public class intbyte : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int형 변수 x를 선어하고 255로 초기화
        int x = 255;

        //byte형 y를 선언하고 x의 값으로 초기화
        //byte의 저장 법위 : 0~255
        byte y = (byte)x;
        Debug.Log(x + "->" + y);
    }
}
