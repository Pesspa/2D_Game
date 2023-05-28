using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetDamage : MonoBehaviour
{
//    public Renderer[] renderers;
    public Image imageBloodDisplay;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody)
        {
            if (collision.rigidbody.GetComponent<PlayerHealth>())
            {
                collision.rigidbody.GetComponent<PlayerHealth>().Damage(1f);
                StartCoroutine(BloodDisplay());
//                StartCoroutine(Blink());
            }
        }
    }
    IEnumerator BloodDisplay()
    {
        imageBloodDisplay.enabled = true;
        for (float t = 1f; t >= 0f; t-= Time.deltaTime)
        {
            imageBloodDisplay.color = new Color(1f, 0f, 0f, t);
            yield return null;
        }
        imageBloodDisplay.enabled = false;
    }
    private void Start()
    {
        imageBloodDisplay.color = new Color(0f, 0f, 0f, 0f);
    }
/*    IEnumerator Blink()
    {
        for(float i = 0f; i <= 2f; i+= Time.deltaTime)
        {
            for(int j = 0; j < renderers.Length; j++)
            {
                renderers[j].material.SetColor("_EmissionColor", new Color(Mathf.Sin(i * 20f) * 0.5f + 0.5f, 0f, 0f, 0f));
            }
        }
        yield return null;
*/    
}
