using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadonlyAndConst : MonoBehaviour
{
    public const string NAME = "Ivan";

    private readonly int _health; // Значение можно присвоить в конструкторе или при инициализации
    public int MaxHealth { get; set; } // get-only свойство под капотом создаёт readonly-поле и геттер к нему
                                       // 


}
