﻿using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour {
	public int _Lives = 3;
    private int _Points;

    public Text livesValue;
    public Text pointsValue;
    public GameObject gameOverSign;
	public GameObject youWinSign;

    public void SetLives(int newValue) {
        _Lives = newValue;
        Debug.Log("Lives now equals: " + _Lives);
        livesValue.text = _Lives.ToString();

        if(_Lives == 0) {
            gameOverSign.SetActive(true);
        }
    }

    public int GetLives() {
        return _Lives;
    }

    public void SetPoints(int newValue) {
        _Points = newValue;
        pointsValue.text = _Points.ToString();

		if (_Points == 25) {
			youWinSign.SetActive (true);
		}
    }
    public int GetPoints() {
        return _Points;
    }
}
