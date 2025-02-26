//[1] 네임스페이스 선언부
using UnityEngine; //현제(fileNew)클래스 파일에서 UnityEngine이라는 네임스페이스를 사용하겠다.

//[2] 클래스 선언부 : 클래스의 이름은 FileNew
public class FileNew : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // [3] (srart)메서드 선언 : 프로그램을 시작할때 1번만 실행
    void Start()
    {
        //[5] 명령문: 콘솔창 출력문
        Debug.Log("Heollow World!!!");
    }

    // Update is called once per frame
    //[4] (Update)메서드 선언 : 프로그램 시작후에 매 프렐임마다 실행
    void Update()
    {
        
    }
}
