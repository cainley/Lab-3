using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inheritance
{
    public class RedBead : Item
    {
        public override void UseItem()
        {
            base.UseItem();
            Debug.Log("Gained 5 health!");
        }
    }
}
