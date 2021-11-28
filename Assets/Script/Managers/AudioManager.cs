using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance = null;
    public AudioSource asBGM;
    public AudioSource asSE;
    public AudioClip acBGMMenu;
    public AudioClip acBGMHouse;
    public AudioClip acBGMJungle;
    public AudioClip acBGMTowerEntry;
    public AudioClip acBGMScene2;
    public AudioClip acBGMScene3;
    public AudioClip acBGMScene4;
    public AudioClip acBGMScene5;
    public AudioClip acBGMScene6;
    public AudioClip acBGMExtra1;
    public AudioClip acSEPlayerWalking;
    public AudioClip acSEPlayerRunning;
    public AudioClip acSEPlayerBasicSwordFire;
    public AudioClip acSEPlayerBasicBowFire;
    public AudioClip acSEPlayerGameOver;
    public AudioClip acSEPlayerHurt1;
    public AudioClip acSEPlayerHurt2;


    public enum BackgroundMusic
    {
        BackgroundMusicMenu,
        BackgroundMusicHouse,
        BackgroundMusicJungle,
        BackgroundMusicTowerEntry,
        BackgroundMusicScene2,
        BackgroundMusicScene3,
        BackgroundMusicScene4,
        BackgroundMusicScene5,
        BackgroundMusicScene6,
        BackgroundMusicExtra1
    }

    public enum SoundEffect
    {
        PlayerWalking,
        PlayerRunning,
        PlayerBasicSwordFire,
        PlayerBasicBowFire,
        PlayerGameOver,
        PlayerHurt1,
        PlayerHurt2
    }

    protected AudioManager() { }

    void Awake()
    {
        //Check if instance already exists
        if (instance == null)
        {
            //if not, set instance to this
            instance = this;
            //Sets this to not be destroyed when reloading scene
            DontDestroyOnLoad(this.gameObject);

            Instantiate(this.asBGM);
            DontDestroyOnLoad(this.asBGM);

            Instantiate(this.asSE);
            DontDestroyOnLoad(this.asSE);
        }
        //If instance already exists and it's not this:
        else if (instance != this)
        {
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(this.gameObject);
        }
    }

    public void Update()
    {
        if (GameManager.instance)
        {
            GameObject.FindGameObjectWithTag("BGM").GetComponent<AudioSource>().enabled = GameManager.instance.saveData.bgmEnabled;
            GameObject.FindGameObjectWithTag("BGM").GetComponent<AudioSource>().volume = GameManager.instance.saveData.bgmLvl * 0.01f;
            GameObject.FindGameObjectWithTag("SE").GetComponent<AudioSource>().enabled = GameManager.instance.saveData.seEnabled;
            GameObject.FindGameObjectWithTag("SE").GetComponent<AudioSource>().volume = GameManager.instance.saveData.seLvl * 0.01f;
        }
        
    }

    public void PlayBackgroundMusic(BackgroundMusic type)
    {
        StartCoroutine(PlayingBackgroundMusic(type));
    }

    IEnumerator PlayingBackgroundMusic(BackgroundMusic type)
    {
        switch (type)
        {
            case BackgroundMusic.BackgroundMusicMenu:
                if (asBGM.isPlaying)
                {
                    Destroy(asBGM);
                }
                if (!asBGM.gameObject.scene.IsValid())
                {
                    
                    Instantiate(asBGM);
                }
                asBGM.enabled = true;
                asBGM.gameObject.SetActive(true);
                asBGM.clip = acBGMMenu;
                asBGM.Play();
                break;

            case BackgroundMusic.BackgroundMusicHouse:
                if (asBGM.isPlaying)
                {
                    Destroy(asBGM);
                }
                if (!asBGM.gameObject.scene.IsValid())
                {   
                    Instantiate(asBGM);
                    asBGM.clip = acBGMHouse;
                }
                asBGM.enabled = true;
                asBGM.gameObject.SetActive(true);
                asBGM.Play();
                break;

            case BackgroundMusic.BackgroundMusicJungle:
                if (asBGM.isPlaying)
                {
                    Destroy(asBGM);
                }
                if (!asBGM.gameObject.scene.IsValid())
                {
                    Instantiate(asBGM);
                    asBGM.clip = acBGMJungle;
                }
                asBGM.enabled = true;
                asBGM.gameObject.SetActive(true);
                asBGM.Play();
                break;

            case BackgroundMusic.BackgroundMusicTowerEntry:
                if (asBGM.isPlaying)
                {
                    Destroy(asBGM);
                }
                if (!asBGM.gameObject.scene.IsValid())
                {
                    Instantiate(asBGM);
                    asBGM.clip = acBGMTowerEntry;
                }
                asBGM.enabled = true;
                asBGM.gameObject.SetActive(true);
                asBGM.Play();
                break;

            case BackgroundMusic.BackgroundMusicScene2:
                if (asBGM.isPlaying)
                {
                    Destroy(asBGM);
                }
                if (!asBGM.gameObject.scene.IsValid())
                {
                    Instantiate(asBGM);
                    asBGM.clip = acBGMScene2;
                }
                asBGM.enabled = true;
                asBGM.gameObject.SetActive(true);
                asBGM.Play();
                break;

            case BackgroundMusic.BackgroundMusicScene3:
                if (asBGM.isPlaying)
                {
                    Destroy(asBGM);
                }
                if (!asBGM.gameObject.scene.IsValid())
                {
                    Instantiate(asBGM);
                    asBGM.clip = acBGMScene3;
                }
                asBGM.enabled = true;
                asBGM.gameObject.SetActive(true);
                asBGM.Play();
                break;
            case BackgroundMusic.BackgroundMusicScene4:
                if (asBGM.isPlaying)
                {
                    Destroy(asBGM);
                }
                if (!asBGM.gameObject.scene.IsValid())
                {
                    Instantiate(asBGM);
                    asBGM.clip = acBGMScene4;
                }
                asBGM.enabled = true;
                asBGM.gameObject.SetActive(true);
                asBGM.Play();
                break;
            case BackgroundMusic.BackgroundMusicScene5:
                if (asBGM.isPlaying)
                {
                    Destroy(asBGM);
                }
                if (!asBGM.gameObject.scene.IsValid())
                {
                    Instantiate(asBGM);
                    asBGM.clip = acBGMScene5;
                }
                asBGM.enabled = true;
                asBGM.gameObject.SetActive(true);
                asBGM.Play();
                break;
            case BackgroundMusic.BackgroundMusicScene6:
                if (asBGM.isPlaying)
                {
                    Destroy(asBGM);
                }
                if (!asBGM.gameObject.scene.IsValid())
                {
                    Instantiate(asBGM);
                    asBGM.clip = acBGMScene6;
                }
                asBGM.enabled = true;
                asBGM.gameObject.SetActive(true);
                asBGM.Play();
                break;

            case BackgroundMusic.BackgroundMusicExtra1:
                if (asBGM.isPlaying)
                {
                    Destroy(asBGM);
                }
                if (!asBGM.gameObject.scene.IsValid())
                {
                    Instantiate(asBGM);
                    asBGM.clip = acBGMExtra1;
                }
                asBGM.enabled = true;
                asBGM.gameObject.SetActive(true);
                asBGM.Play();
                break;
        }
        yield return null; ;
    }

    public void PlaySoundEffect(SoundEffect type)
    {
        StartCoroutine(PlayingSoundEffect(type));
    }

    IEnumerator PlayingSoundEffect(SoundEffect type)
    {
        switch (type)
        {
            case SoundEffect.PlayerWalking:
                asSE.clip = acSEPlayerWalking;
                asSE.Play();
                break;
            case SoundEffect.PlayerRunning:
                asSE.clip = acSEPlayerRunning;
                asSE.Play();
                break;
            case SoundEffect.PlayerBasicSwordFire:
                asSE.clip = acSEPlayerBasicSwordFire;
                asSE.Play();
                break;
            case SoundEffect.PlayerBasicBowFire:
                asSE.clip = acSEPlayerBasicBowFire;
                asSE.Play();
                break;
            case SoundEffect.PlayerHurt1:
                asSE.clip = acSEPlayerHurt1;
                asSE.Play();
                break;
            case SoundEffect.PlayerHurt2:
                asSE.clip = acSEPlayerHurt2;
                asSE.Play();
                break;
            case SoundEffect.PlayerGameOver:
                asSE.clip = acSEPlayerGameOver;
                asSE.Play();
                break;
        }
        yield return null;
    }

    public void StopAllBackgroundMusic()
    {
        asBGM.Stop();
    }
}
