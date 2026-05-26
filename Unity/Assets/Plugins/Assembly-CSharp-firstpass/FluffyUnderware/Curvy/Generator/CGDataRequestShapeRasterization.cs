namespace FluffyUnderware.Curvy.Generator
{
	public class CGDataRequestShapeRasterization : CGDataRequestRasterization
	{
		public float[] PathF;

		public CGDataRequestShapeRasterization(float[] pathF, float start, float rasterizedRelativeLength, int resolution, float angle, ModeEnum mode = ModeEnum.Even)
			: base(0f, 0f, 0, 0f)
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
