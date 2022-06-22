using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Enemy
{


    // Start is called before the first frame update
    public override void Start()
    {
        base.speed = 1.5f;
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }

    
}
