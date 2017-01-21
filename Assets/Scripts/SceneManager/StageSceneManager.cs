﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSceneManager : MonoBehaviour {

    public NarratorEngine narrator;

	void Start () {
        this.ShowSceneNarration();	
	}

    private void ShowSceneNarration()
    {
        narrator.ShowNarration();
    }
}
