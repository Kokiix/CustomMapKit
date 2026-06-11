using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Examples
{
	public class HeightMetadata : CurvyInterpolatableMetadataBase<float>
	{
		[SerializeField]
		[RangeEx(0f, 1f, "", "", Slider = true)]
		private float m_Height;

		public override float MetaDataValue => 0f;

		public override float Interpolate(CurvyInterpolatableMetadataBase<float> nextMetadata, float interpolationTime)
		{
			return 0f;
		}
	}
}
