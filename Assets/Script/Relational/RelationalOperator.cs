using UnityEngine;

//RelationalOperator(������ ������,�� ������) 
// <(����), <=(�۰ų� ����), >(ũ��), =>(ũ�ų� ����), ==(����), !=(�ٸ�)
//��� : true(��), false(����)
public class RelationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;
        Debug.Log(x < y);   //x�� t���� ������?   => true
        Debug.Log(x <= y);  //x�� t���� �۰ų� ������?   => true
        Debug.Log(x > y);   //x�� t���� ũ��?    => false
        Debug.Log(x >= y);  //x�� t���� ũ�ų� ������?   => false
        Debug.Log(x == y);  //x�� t�� ����? => false
        Debug.Log(x != y);  //x�� t�� �ٸ���?    => true
        Debug.Log("AAA" == "aaa"); // => false???   �빮��, �ҹ��� ������
    }
}
