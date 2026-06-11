namespace FluffyUnderware.Curvy.Generator
{
	public class CGDataRequestMetaCGOptions : CGDataRequestParameter
	{
		public bool CheckHardEdges;

		public bool CheckMaterialID;

		public bool IncludeControlPoints;

		public bool CheckExtendedUV;

		public CGDataRequestMetaCGOptions(bool checkEdges, bool checkMaterials, bool includeCP, bool extendedUV)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
