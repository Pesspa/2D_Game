using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAcorn : MonoBehaviour
{
    public GameObject AcornGameObject;
    public Transform[] pointsTransform;
    [ContextMenu("SpawnAcorn")]
    private void SpawnAcorn()
    {
        for(int i = 0; i < pointsTransform.Length; i++)
        {
            Instantiate(AcornGameObject, pointsTransform[i].position, pointsTransform[i].rotation);
        }
    }
}
