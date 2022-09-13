using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RandomSoundPlayer : MonoBehaviour
{
    [SerializeField] List<AudioClip> Sounds;
    AudioMixerGroup vfxMixerGroup;
    private void Start()
    {
        vfxMixerGroup = StaticHelper.Instance.AudioMixer;
    }
    public void PlayRandomClip()
    {
        if (Sounds != null)
        {
            var randomIndex = Random.Range(0, Sounds.Count);
            PlayClipAtPoint(Sounds[randomIndex],transform.position, vfxMixerGroup);  
        }
    }
    public static void PlayClipAtPoint(AudioClip clip, Vector3 position, AudioMixerGroup group, float volume =1f)
    {
        GameObject gameObject = new GameObject("One shot audio");
        gameObject.transform.position = position;
        AudioSource audioSource = (AudioSource)gameObject.AddComponent(typeof(AudioSource));
        audioSource.clip = clip;
        audioSource.spatialBlend = 1f;
        audioSource.volume = volume;
        audioSource.outputAudioMixerGroup = group;
        audioSource.Play();
        Object.Destroy(gameObject, clip.length * ((Time.timeScale < 0.01f) ? 0.01f : Time.timeScale));
    }
}
