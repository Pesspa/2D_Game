using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTriggerEveryNSeconds : MonoBehaviour
{
    public Animator animator;
    private float _timer;
    public float attackPeriod = 5f;

    public string nameOfTrigger;

    void Update()
    {
        _timer+= Time.deltaTime;
        if(_timer > attackPeriod)
        {
            _timer=0;
            animator.SetTrigger(nameOfTrigger);
        }
    }
}
