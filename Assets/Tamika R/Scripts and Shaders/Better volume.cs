using UnityEngine;

public class AdjustVolume : MonoBehaviour
{
    public AudioSource[] outsideAmbianceSources;
    public AudioSource[] caveAmbianceSources;
    public float newVolume = 1.0f; // The volume level you want to set (range from 0 to 1)

    void Start()
    {
        SetVolume(outsideAmbianceSources, newVolume);
        SetVolume(caveAmbianceSources, newVolume);
    }

    void SetVolume(AudioSource[] audioSources, float volume)
    {
        foreach (var audioSource in audioSources)
        {
            audioSource.volume = volume;
        }
    }
}
