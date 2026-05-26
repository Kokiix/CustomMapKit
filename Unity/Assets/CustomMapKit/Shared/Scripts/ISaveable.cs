using Newtonsoft.Json.Linq;

public interface ISaveable
{
	object SaveState();

	void LoadState(JContainer state);
}
