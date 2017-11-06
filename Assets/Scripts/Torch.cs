using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : Consumable{

    public override void Use()
    {
        if (isBroken)
            return;

        while (!isBroken)
        {
            for (float f = 1f; f >= 0; f -= 0.1f)
            {
                //torch.setParticleEmitter() or whatever to get light
                durability -= 1;
                //yield return WaitForSeconds(0.1f);
            }
        }

        if (durability < 0)
            isBroken = true;

    }

}
