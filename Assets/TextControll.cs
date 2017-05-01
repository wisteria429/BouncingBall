using HoloToolkit.Unity.SpatialMapping;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextControll : MonoBehaviour {

    public SpatialMappingManager mapping;

    private bool isStart = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (!isStart && mapping.GetMeshes().Count != 0) {
            // SpatialMappingのメッシュが生成されたら1度だけ通る
            isStart = true;
            TextMesh textMesh = gameObject.GetComponent<TextMesh>();
            textMesh.text = "AirTapでボールを発射！";
        }

            
	}
}
