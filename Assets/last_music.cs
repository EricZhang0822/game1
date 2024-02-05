using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class last_music : MonoBehaviour
{
    [SerializeField] private AudioSource gunshot;
    [SerializeField] private float timer;
    [SerializeField] private float end_timer;
    // Start is called before the first frame update
    void Start()
    {
        gunshot.PlayDelayed(timer);
    }

    void Update()
    {
        end_timer -= Time.deltaTime;
        if (timer <= -0.5)
            Application.Quit();
    }

}
