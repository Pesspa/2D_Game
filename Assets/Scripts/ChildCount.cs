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
            // ������� ���������� �� �������� ������� ���� � �����, ������� ������ ����� �������, 
            // ����� � ����� �� ���������� ������ ��������, ����� ����������� ����������� 
        }
    }
}
