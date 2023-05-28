using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun
{
    public ParticleSystem smokePistol;
    public override void Shot()
    {
        {
            base.Shot();
            smokePistol.Play();
        }
    }
}
