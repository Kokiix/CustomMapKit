using UnityEngine;

namespace FluffyUnderware.Curvy
{
	[ExecuteInEditMode]
	public abstract class CurvyInterpolatableMetadataBase<T> : CurvyMetadataBase
	{
		public abstract T MetaDataValue { get; }

		public abstract T Interpolate(CurvyInterpolatableMetadataBase<T> nextMetadata, float interpolationTime);
	}
}
