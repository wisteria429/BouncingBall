using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Windows.Speech;

public class BouncingBall : MonoBehaviour, IInputClickHandler {
    public GameObject pubfubBall;


    // Use this for initialization
    void Start () {
        Debug.Log("start");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("click");
        Vector3 forward = Camera.main.transform.TransformDirection(Vector3.forward);
        
        GameObject ball = Instantiate(pubfubBall);
        ball.transform.position = Camera.main.transform.TransformPoint(0, 0, 1.2f);
        Rigidbody ballRigitBody = ball.GetComponent<Rigidbody>();
        Debug.Log("forward:" + forward.ToString());

        // カメラで見ている方向に移動量を追加
        ballRigitBody.AddForce(forward * 5, ForceMode.Impulse);
        
    }

}
