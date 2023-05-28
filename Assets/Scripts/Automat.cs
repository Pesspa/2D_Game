using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Automat : Gun
{
    public ParticleSystem smokeAutomat;
    [Space(10)]
    [Header("Automat")]
    public Text bulletCountText;
    public int bulletCount;

    private void Start()
    {
        bulletCountText.text = "Пули: " + bulletCount.ToString();
    }
    public override void Shot()
    {
        if(bulletCount > 0) {
            base.Shot();
            bulletCount--;
            bulletCountText.text = "Пули: " + bulletCount.ToString();
            smokeAutomat.Play();
            if (bulletCount == 0)
            {
                
                bulletCountText.enabled = false;
            }
        }
    }
       public override void AddBullet(int bullets)
    {
        base.AddBullet(bullets);
        bulletCount += bullets;
        bulletCountText.text = "Пули: " + bulletCount.ToString();
    }
}
