using UnityEngine;

public class IfDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        int x = 10;

        //���� x�� 10�̸� x�� 10�Դϴٸ� �ⷫ

        if (x == 10) Debug.Log("x�� 10�Դϴ�");
        

        //���� x�� 20�� �ƴϸ� x�� 20�� �ƴմϴ�

        if(x != 20) Debug.Log("x�� 20�� �ƴմϴ�");
    }
}
