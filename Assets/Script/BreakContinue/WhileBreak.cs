using Unity.VisualScripting;
using UnityEngine;

//"1부터 10까지의 정수의 합을 구하는 프로그램 구현
//구한 합이 22이상이되면 더이상 합을 구하지않는다
public class WhileBreak : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int sum = 0;
        int goal = 22;

        int i = 0;

        while(i <= n)
        {
            sum += i;
            if (sum >=goal)
            {
                break;
            }

            i++;
        }
    }
}
