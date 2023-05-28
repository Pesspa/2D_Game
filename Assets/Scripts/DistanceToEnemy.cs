using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class DistanceToEnemy : MonoBehaviour
{
    public float maxDistance;
    public bool isActive = true;
    private Activator _activator;

    private void Start()
    {
        _activator = FindObjectOfType<Activator>();
        FindObjectOfType<Activator>().Enemies.Add(this);
    }
    public void Checkdistance(Vector3 playerTransform)
    {
        float distance = Vector3.Distance(transform.position, playerTransform);
        if (maxDistance + 2f < distance) 
        {
            if (isActive)
                DeActivateEnemis();
        }
        else
        {
            ActivateEnemis();
        }
    }
    void ActivateEnemis()
    {
        if (isActive) return;

        isActive = true;
        gameObject.SetActive(true);
    }
    void DeActivateEnemis()
    {
        if (isActive == false) return;

        isActive = false;
        gameObject.SetActive(false);
    }
    private void OnDestroy()
    {
        _activator.Enemies.Remove(this);
    }
#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        Handles.DrawWireDisc(transform.position,Vector3.forward, maxDistance);
    }
#endif
}
