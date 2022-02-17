using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace EatingGold
{
    public class SceneControl : MonoBehaviour
    {
        public GameObject[] Clouds;

        public AudioClip WindAudioClip;
        public AudioClip BirdAudioClip;

        private float m_WindSoundPlayGap = 5f;
        private float m_BirdSoudPlayGap = 7f;

        private float m_WinSoudnPlayTime = 5f;
        private float m_BirdSoundPlayTime = 5f;

        private AudioSource m_AudioSource;

        
        private void PlayAudioClip(AudioClip m_Clip)
        {
            m_AudioSource.clip = m_Clip;
            m_AudioSource.Play();
        }
    

        // Start is called before the first frame update
        void Start()
        {
            m_AudioSource = GetComponent<AudioSource>();

        }

        // Update is called once per frame
        void Update()
        {

            if (Time.time > m_WinSoudnPlayTime)
            {
                m_WinSoudnPlayTime += m_WindSoundPlayGap;
                PlayAudioClip(WindAudioClip);
            }
            
            if (Time.time > m_BirdSoundPlayTime)
            {
                m_BirdSoundPlayTime += m_BirdSoudPlayGap;
                PlayAudioClip(BirdAudioClip);
            }

        }
    }
}
