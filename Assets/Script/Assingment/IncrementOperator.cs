using UnityEngine;

//IncrementOperator(����������) : ������ ������ ���� 1 ���� 
public class IncrementOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 100;
        // 1 ������ 
        //num = num + 1;
        //num += 1;
        ++num;  // 101
        Debug.Log("num: " + num); 

    }
}
