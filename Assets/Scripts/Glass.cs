using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inheritance
{
    public class Glass : Item
    {
        public override void UseItem()
        {
            base.UseItem();
            Debug.Log("You broke some window. Hope you feel accomplished with your life.");
        }
    }
}
