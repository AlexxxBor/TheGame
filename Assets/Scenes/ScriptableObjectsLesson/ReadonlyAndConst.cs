using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadonlyAndConst : MonoBehaviour
{
    public const string NAME = "Ivan";

    private readonly int _health; // �������� ����� ��������� � ������������ ��� ��� �������������
    public int MaxHealth { get; set; } // get-only �������� ��� ������� ������ readonly-���� � ������ � ����
                                       // 


}
