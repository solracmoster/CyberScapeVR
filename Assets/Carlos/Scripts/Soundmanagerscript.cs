﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundmanagerscript : MonoBehaviour {
    // to add a sound put its name use a , after a sound to add another                                           //script set up with "shootp" so you can test if it works
    //ex: public st...shootpSound, JumpSound;
    public static AudioClip shootpSound, PHurt, punch, attack, HP, EDie, Hit2, JumpN, Travel, Coin, NHP, NHurt, EHurt;

    //don't touch
    static AudioSource audioSrc;

	
	void Start () {
    //In order to add another sound (the one you put above) copy, paste and replace and place below.
   //ex:JumpSound = Resources.Load<AudioClip>("Jump");

        shootpSound = Resources.Load<AudioClip>("shootp");
        PHurt = Resources.Load<AudioClip>("PHurt");
        punch = Resources.Load<AudioClip>("punch");
        attack = Resources.Load<AudioClip>("attack");
        HP = Resources.Load<AudioClip>("HP");
        EDie = Resources.Load<AudioClip>("EDie");
        Hit2 = Resources.Load<AudioClip>("Hit2");
        JumpN = Resources.Load<AudioClip>("JumpN");
        Travel = Resources.Load<AudioClip>("Travel");
        Coin = Resources.Load<AudioClip>("Coin");
        NHP = Resources.Load<AudioClip>("NHP");
        NHurt = Resources.Load<AudioClip>("NHurt");
        EHurt = Resources.Load<AudioClip>("EHurt");

        // don't touch
        audioSrc = GetComponent<AudioSource>();

	}
	
	
	void Update () {
		
	}


    //copy, paste, replace, place

 //  ex:           switch (clip)
 //             {
 //                 case "JumpSound":
 //                 audioSrc.PlayOneShot(JumpSound);
 //                 break;
 //         }
 

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "shootp":
                audioSrc.PlayOneShot(shootpSound);
                break;
        }
        switch (clip)
        {
            case "PHurt":
                audioSrc.PlayOneShot(PHurt);
                break;
        }
        switch (clip)
        {
            case "punch":
                audioSrc.PlayOneShot(punch);
                break;
        }
        switch (clip)
        {
            case "attack":
                audioSrc.PlayOneShot(attack);
                break;
        }
        switch (clip)
        {
            case "HP":
                audioSrc.PlayOneShot(HP);
                break;
        }
        switch (clip)
        {
            case "EDie":
                audioSrc.PlayOneShot(EDie);
                break;
        }
        switch (clip)
        {
            case "Hit2":
                audioSrc.PlayOneShot(Hit2);
                break;
        }
        switch (clip)
        {
            case "JumpN":
                audioSrc.PlayOneShot(JumpN);
                break;
        }
        switch (clip)
        {
            case "Travel":
                audioSrc.PlayOneShot(Travel);
                break;
        }
        switch (clip)
        {
            case "Coin":
                audioSrc.PlayOneShot(Coin);
                break;
        }
        switch (clip)
        {
            case "NHP":
                audioSrc.PlayOneShot(NHP);
                break;
        }
        switch (clip)
        {
            case "NHurt":
                audioSrc.PlayOneShot(NHurt);
                break;
        }
        switch (clip)
        {
            case "EHurt":
                audioSrc.PlayOneShot(EHurt);
                break;
        }
        //  ex:           switch (clip)
        //             {
        //                 case "JumpSound":
        //                 audioSrc.PlayOneShot(JumpSound);
        //                 break;
        //         }

    }


}
//Use this in another script to have your sound play after something, put it after you jump or when you get hit stuff like that go nuts.
//Soundmanagerscript.PlaySound("shootp");