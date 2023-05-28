using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    public float helth = 1f;

    public UnityEvent OnDie;

    public void TakeDamage(float damage)
    {
        helth -= damage;
        if(helth <= 0)
            EnemyDie();
    }
    public void EnemyDie()
    {
        Destroy(this.gameObject);
        OnDie.Invoke();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody)
        {
            if (collision.rigidbody.GetComponent<Bullet>())
                TakeDamage(1);
        }
        
    }
}
