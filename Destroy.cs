using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // в начале игры уничтожает объект
    void Start()
    {
        Destroy(gameObject);
    }
}
