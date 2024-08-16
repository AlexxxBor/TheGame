using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLesson : MonoBehaviour
{
    public bool ShowMom;
    public int N;
    public string Counting = "Abrakadabra";
    public char Search = 'a';

    private void Start()
    {
        if (ShowMom)
        {
            ShowMotherInfo();
        }
    }

    private void OnValidate()
    {
        if (Counting.Length > 0 && Search != '\0')
        {
            Debug.Log($"���������� �������� \"{Search}\" � ������ \"{Counting}\": {ForeachExample(Counting, Search)}");
        }

        if (N is 0)
        {
            return;
        }

        Debug.Log($"����� ����� �� 1 �� {N} ����� {GetSumUpTo(N)}");
        Debug.LogWarning($"����������� ����� �� 1 �� {N} ����� {GetSumRecursively(N)}");
        Debug.Log($"�������� i ���� ����� Do-While: {DoWhile(1000)}");
        Debug.Log($"�������� i ���� ����� While: {WhileExample(100)}");
    }

    private void ShowMotherInfo()
    {
        for (int i = 10; i > 0; i--)
        {
            Debug.LogError("Mom");
        }
    }

    private int GetSumUpTo(int n)
    {
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        return sum;
    }

    private int GetSumRecursively(int n)
    {
        if (n == 0)
        {
            return 0;
        }

        return n + GetSumRecursively(n - 1);
    }

    private int DoWhile(int n)
    {
        int i = 0;

        do
        {
            i++;
            n /= 10;
        } while (n > 0);

        return i;
    }

    private int WhileExample(int n)
    {
        int i = 0;

        while (n > 0)
        {
            i++;
            n -= 10;
        } 

        return i;
    }

    private int ForeachExample(string str, char counting)
    {
        int i = 0;
        foreach (char letter in str)
        {
            if (letter == counting)
            {
                i++;
            }
        }
        return i;
    }
}