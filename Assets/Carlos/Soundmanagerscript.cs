using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundmanagerscript : MonoBehaviour {
    // to add a sound put its name use a , after a sound to add another                                           //script set up with "shootp" so you can test if it works
    //ex: public st...shootpSound, JumpSound;
    public static AudioClip shootpSound;

    //don't touch
    static AudioSource audioSrc;

	
	void Start () {
    //In order to add another sound (the one you put above) copy, paste and replace and place below.
   //ex:JumpSound = Resources.Load<AudioClip>("Jump");

        shootpSound = Resources.Load<AudioClip>("shootp");
        
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