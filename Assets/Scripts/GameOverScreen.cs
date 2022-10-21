using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public GameObject turnsGO;

    public Text turnsText;

    private void Start()
    {
        turnsText.text = PlayerPrefs.GetString("Turnes: ");
    }
}
