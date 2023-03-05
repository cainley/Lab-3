using UnityEngine;

namespace Inheritance
{
	public class Box : Item
	{
		public int Uses;

		public override void UseItem()
		{
			Uses--;
			if (Uses >= 0)
			{
				Debug.Log("You tried sitting in the box, the edges began to rip...");
			}
			else
			{
				Debug.Log("If I fit, I sit! But the box broke on itself by you.");
				Destroy(this.gameObject);
			}
		}
	}
}
