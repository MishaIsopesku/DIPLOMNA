﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G2Sound : MonoBehaviour
{
    public AudioSource Audio;

    public PlayerMove move;

    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Audio.pitch = (move.speed) / 12;
        if (move.speed < 0)
        {
            Audio.enabled = false;
        }
    }
}
