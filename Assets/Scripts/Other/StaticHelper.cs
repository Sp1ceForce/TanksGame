using System;
using UnityEngine;
using UnityEngine.Audio;

public class StaticHelper : MonoBehaviour
{
    public static StaticHelper Instance { get; private set; }
    public GameObject PlayerObject { get; private set; }
    public StatsComponent PlayerStats { get; private set; }
    [SerializeField] private AudioMixerGroup audioMixer;
    public AudioMixerGroup AudioMixer { get => audioMixer; }
    void Awake()
    {
        CheckInstance();
        GetRequiredObjects();
    }

    private void GetRequiredObjects()
    {
        PlayerObject = GameObject.FindGameObjectWithTag("Player");
        PlayerStats = GetComponent<StatsComponent>();
    }

    private void CheckInstance()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("More than one EnemyStatics!");
        }
    }

  
}
