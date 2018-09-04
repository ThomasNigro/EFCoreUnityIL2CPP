using DLLs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EFCoreTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Test test = new Test();
        test.Strings.Add("coucou");
        test.SaveChanges();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
