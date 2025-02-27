using UnityEngine;
using System.Collections;

public class SomeotherClass2 : MonoBehaviour
{
    void Start()
    {
        SomeClass2 myClass = new SomeClass2();

        myClass.GenericMethod<int>(5);
    }
}