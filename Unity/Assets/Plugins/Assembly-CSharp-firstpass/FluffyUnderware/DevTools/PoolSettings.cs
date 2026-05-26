using System;
using UnityEngine;

namespace FluffyUnderware.DevTools
{
	[Serializable]
	public class PoolSettings
	{
		[SerializeField]
		private bool m_Prewarm;

		[SerializeField]
		private bool m_AutoCreate;

		[SerializeField]
		private bool m_AutoEnableDisable;

		[Positive]
		[SerializeField]
		private int m_MinItems;

		[Positive]
		[SerializeField]
		private int m_Threshold;

		[Positive]
		[SerializeField]
		private float m_Speed;

		public bool Debug;

		public bool Prewarm
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AutoCreate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AutoEnableDisable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int MinItems
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Threshold
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float Speed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public PoolSettings()
		{
		}

		public PoolSettings(PoolSettings src)
		{
		}

		public void OnValidate()
		{
		}
	}
}
