using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inheritance
{
    public class Item : MonoBehaviour
    {
		public string Name;
		public int Cost;
		public bool Consumable;

		private void OnMouseDown()
		{
			UseItem();
		}

		public virtual void UseItem()
		{
			Debug.Log("Using " + Name);
			if (Consumable)
			{
				Destroy(this.gameObject);
			}
		}
	}
}
