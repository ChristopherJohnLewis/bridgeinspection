﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class camView : MonoBehaviour {
    public Camera mainCamera;

    public Transform viewOne;
    public Transform viewTwo;
    public Transform viewThree;

    private int viewPosition;

    // Use this for initialization
    void Start () {
        viewPosition = 1;
        getPosition(viewPosition);

		
	}
	
	// Update is called once per frame
	void Update () {

        getPosition(viewPosition);

    }

    private void getPosition(int position)
    {
        switch (position)
        {
            case 1:
                camViewOne();
                break;
            case 2:
                camViewTwo();
                break;
            case 3:
                camViewThree();
                break;
        }
    }

    private void camViewOne()
    {
        mainCamera.transform.SetPositionAndRotation(viewOne.position, viewOne.rotation);
    }
    private void camViewTwo()
    {
        mainCamera.transform.SetPositionAndRotation(viewTwo.position, viewTwo.rotation);
    }
    private void camViewThree()
    {
        mainCamera.transform.SetPositionAndRotation(viewThree.position, viewThree.rotation);
    }

    public void setCamViewPosition(int newposition)
    {
        viewPosition = newposition;
    }

}