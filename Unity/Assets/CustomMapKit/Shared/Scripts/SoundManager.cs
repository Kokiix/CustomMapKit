using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
	public static SoundManager Instance;

	public PauseManager pauseManager;

	private Settings settings;

	[SerializeField]
	public AudioSource _musicSource;

	[SerializeField]
	public AudioSource _effectsSource;

	[SerializeField]
	public AudioSource _ambientSource;

	[SerializeField]
	private AudioLowPassFilter lowpassFilter;

	[SerializeField]
	private AudioHighPassFilter highpassFilter;

	[SerializeField]
	private float lowpass;

	[SerializeField]
	private float highpass;

	public bool SetLowpass;

	public bool SetHighpass;

	public float menuMusicVolume;

	public float lerpSpeed;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void PlaySound(AudioClip clip)
	{
	}

	public void PlaySoundWithPitch(AudioClip clip, float pitch)
	{
	}

	public void PlayAmbientSound(AudioClip clip)
	{
	}

	public void PlayMusic(AudioClip clip, int loop)
	{
	}

	public void StopAllMusic()
	{
	}

	public void StopSound()
	{
	}

	public void ChangeMasterVolume(float value)
	{
	}

	public void ChangeMusicVolume(float value)
	{
	}

	public void ChangeEffectVolume(float value)
	{
	}

	public void ChangeAmbientVolume(float value)
	{
	}

	public void ChangeMasterVolumeSlider(Slider value)
	{
	}

	public void ChangeMusicVolumeSlider(Slider value)
	{
	}

	public void ChangeEffectVolumeSlider(Slider value)
	{
	}

	public void ChangeAmbientVolumeSlider(Slider value)
	{
	}

	public void ChangeMenuMusicVolumeSlider(Slider value)
	{
	}

	public void ToggleEffects()
	{
	}

	public void ToggleMusic()
	{
	}
}
