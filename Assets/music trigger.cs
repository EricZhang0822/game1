using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_trigger: MonoBehaviour
{
    [SerializeField] private AudioSource currentMusic;
    [SerializeField] private AudioSource newMusic;
    [SerializeField] private last_music last_music;
    [SerializeField] private Collider2D stage;
    [SerializeField] private Transform player;
    [SerializeField] private GameObject cd;
    [SerializeField] private Collider2D child;
    // Start is called before the first frame update
    void Start()
    {
        stage = GetComponent<Collider2D>();
        child = cd.GetComponent<Collider2D>();
        last_music = GetComponent<last_music>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        child.enabled = true;
        if (last_music != null)
            last_music.enabled = true;

            if (other.CompareTag("Player"))
            {
                if (currentMusic.isPlaying)
                {
                    currentMusic.Stop();
                }

                if (!newMusic.isPlaying)
                {
                    newMusic.Play();
                }
            }


    }
}
