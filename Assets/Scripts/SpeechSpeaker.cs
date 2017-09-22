using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechSpeaker : MonoBehaviour {
    public static string textSpeech = "";
    private bool isSpeech = false;
    private bool isCatch = false;
    public AudioSource _audio;


    void Start()
    {
        _audio = GetComponent<AudioSource>();

    }
	public static void requestSpeech(string text, Transform trans)
    {
        SpeechSpeaker.textSpeech = text;
		//GameObject go = Instantiate(Resources.Load("Prefabs/CashierDialog")) as GameObject;

//		((CashierDialog)go).setVisible (text, trans);
//
//		Destroy(go, 3);

//		GameObject aab = (GameObject)Instantiate(go, trans.position, Quaternion.identity) as GameObject;
//		Destroy(aab, 3);

//		GameObject track = (GameObject)Instantiate(Rail, new Vector3(structPoint.transform.position.x, structPoint.transform.position.y, structPoint.transform.position.z), Quaternion.identity);
//		track.name = "track1";

    }
    IEnumerator DownloadTheAudio()
    {
        string text = WWW.EscapeURL(SpeechSpeaker.textSpeech);
		//string url = "https://translate.google.com/translate_tts?ie=UTF-8&q=" + text + "&tl=en&client=tw-ob";
        //  string url = "http://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=Hello%20I%20am%20Happy%20City.%20we%20must%20become%20awesome%20team%20to%20get%20a%20good%20result&tl=En-gb";
        string url = "http://api.voicerss.org/?key=451a1fe169e3464c86de603452f0505e&hl=en-us&src=" + text + "&c=MP3&f=16khz_8bit_stereo&r=0";
        WWW www = new WWW(url);
        yield return www;
        resetSpeech();

        _audio.clip = www.GetAudioClip(false, true, AudioType.MPEG);
        _audio.Play();
        isSpeech = true;
        yield return new WaitForSeconds(_audio.clip.length);
        isSpeech = false;
    }
    void resetSpeech()
    {
        SpeechSpeaker.textSpeech = "";
        isCatch = false;
    }

    void Update()
    {
        if (SpeechSpeaker.textSpeech.Length > 0 && !isSpeech && !isCatch)
        {

            isCatch = true;
            StartCoroutine(DownloadTheAudio());
        }

    }

}
