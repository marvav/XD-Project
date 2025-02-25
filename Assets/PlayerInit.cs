using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Core_Utils;

public class PlayerInit : MonoBehaviour
{
    public Core Core;

    void OnEnable()
    {
        Time.timeScale = 1;
        Core.AudioManager.GeneralMusic.loop = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Core.ProgressManager.changeObjective(0);
    }
}
