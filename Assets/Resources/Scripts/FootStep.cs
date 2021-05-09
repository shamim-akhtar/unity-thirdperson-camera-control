using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStep : MonoBehaviour
{
    public AudioSource mAudioSource;
    public List<AudioClip> mConcreteClips;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayFootStepSound()
    {
        int index = Random.Range(0, mConcreteClips.Count - 1);
        mAudioSource.volume = Random.Range(0.5f, 1.0f);
        mAudioSource.pitch = Random.Range(0.5f, 1.0f);
        mAudioSource.PlayOneShot(mConcreteClips[index]);
    }
}
