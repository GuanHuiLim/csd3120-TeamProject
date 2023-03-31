using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameController : MonoBehaviour
{
    private static int score;
    public UnityEvent startGameEvent = new UnityEvent();
    public static UnityEvent sword_cut_event = new UnityEvent();
    public GameSpawner spawner;
    public AudioSource cut_sound;
    public AudioSource bgm;

    // Start is called before the first frame update
    void Start()
    {
        sword_cut_event.AddListener(PlayCutSound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        spawner.gameObject.SetActive(true);
        bgm.Play();
    }

    public static void AddScore(int points)
    {
        score += points;
    }

    public static int GetScore()
    {
        return score;
    }

    public void PlayCutSound()
    {
        cut_sound.Play();
    }

    static public void LeftControllerX_Axis_Moved(bool activate)
    {
        if (activate)
            Debug.Log("LeftControllerX_Axis_Moved: " + "ACTIVATED");
        else
            Debug.Log("LeftControllerX_Axis_Moved: " + "DE-ACTIVATED");
    }

    static public void LeftControllerY_Axis_Moved(bool activate)
    {
        if (activate)
            Debug.Log("LeftControllerY_Axis_Moved: " + "ACTIVATED");
        else
            Debug.Log("LeftControllerY_Axis_Moved: " + "DE-ACTIVATED");
    }

    static public void LeftController_Axis_Moved(bool activate)
    {
        if (activate)
            Debug.Log("LeftController_Axis_Moved: " + "ACTIVATED");
        else
            Debug.Log("LeftController_Axis_Moved: " + "DE-ACTIVATED");
    }

    static public void LeftHandThumb(bool activate)
    {
        if (activate)
            Debug.Log("LeftHandThumb: " + "ACTIVATED");
        else
            Debug.Log("LeftHandThumb: " + "DE-ACTIVATED");
    }

    static public void Moving()
    {
        Debug.Log("Moving");
    }
}
