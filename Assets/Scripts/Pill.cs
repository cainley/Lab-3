using UnityEngine;

namespace Inheritance
{
	public class Pill : Item
	{
		public int Uses;

		public override void UseItem()
		{
			Uses--;
			if (Uses >= 0)
			{
				Debug.Log("You tried to swallow...");
			}
			else
			{
				Debug.Log("Congrats, you took your medication.");
				Destroy(this.gameObject);
			}
		}
	}
}
