using UnityEngine;

//PostfixOperator (���� ����(++, --)������) : ���� ���ο��� �����ϴ� �켱 ������ ���� ����(���� ���߿� ����)
public class PostfixOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = x++;
        Debug.Log("x: " + x);   //3
        Debug.Log("y: " + y);   //3
    }
}
