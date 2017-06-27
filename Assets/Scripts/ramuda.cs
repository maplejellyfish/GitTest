using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

public class ramuda : MonoBehaviour {  
	List<int> list;  
	bool isFinish;  

	void Start() {  
		isFinish = false;  
		list = new List<int> ();  
		UnityEngine.Random.seed = 12345;  
		for(int i = 0; i < 1000000; i++) {  
			list.Add (UnityEngine.Random.Range (0, 1000));  
		}  
	}  

	void Update() {  
		if (!isFinish) {  
			List<int> time = new List<int> ();  
			for (int i = 0; i < 100; i++) {  
				DateTime start = DateTime.Now;  
				CalcTime ();  
				DateTime end = DateTime.Now;  
				TimeSpan span = end - start;  
				time.Add (span.Milliseconds);  
			}  
			int min = time.Min ();  
			time.Remove (min);  
			int max = time.Max ();  
			time.Remove (max);  
			double avg = time.Average ();  
			Debug.Log ("min:" + min + " max:" + max + " avg:" + avg);  
			isFinish = true;  
		}  
	}  

	void CalcTime() {  
		int count = 0;  
		int search = UnityEngine.Random.Range (0, 1000);  
		// ここ以下を変えます  
		count = list.Count (val => val == search);  
	}  
}  