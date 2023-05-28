using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCount : MonoBehaviour
{
    public int countOfChild;
    void Update()
    {
        if(transform.childCount == countOfChild)
        {
            Destroy(gameObject);
            // скрипты отличаются от скриптов которые есть в курсе, поэтому сделал такой костыль, 
            // чтобы в сцене не остовалось пустых объектов, после уничтожения противников 
        }
    }
}
