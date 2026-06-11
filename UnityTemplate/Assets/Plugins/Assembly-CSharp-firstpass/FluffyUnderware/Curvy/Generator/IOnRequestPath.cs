using System;

namespace FluffyUnderware.Curvy.Generator
{
	[Obsolete("IOnRequestPath is an interface with no added value, and will get removed in a future update. Use IOnRequestProcessing or IPathProvider instead")]
	public interface IOnRequestPath : IOnRequestProcessing, IPathProvider
	{
	}
}
