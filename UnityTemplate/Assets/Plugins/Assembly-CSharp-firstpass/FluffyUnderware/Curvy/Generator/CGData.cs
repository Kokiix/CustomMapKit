namespace FluffyUnderware.Curvy.Generator
{
	public class CGData
	{
		public string Name;

		public virtual int Count => 0;

		public static implicit operator bool(CGData a)
		{
			return false;
		}

		public virtual T Clone<T>() where T : CGData
		{
			return null;
		}

		protected int getGenericFIndex(ref float[] FMapArray, float fValue, out float frag)
		{
			frag = default(float);
			return 0;
		}
	}
}
