using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class watchSelect : MonoBehaviour {

	public Button Previous, Next;
	public GameObject model1;
	public GameObject model2;
	public GameObject model3;

	

	// Use this for initialization
	void Start () {
		
		/*model1 = GetComponent<GameObject>();
		model2 = GetComponent<GameObject>();
		model3 = GetComponent<GameObject>();*/

		model1 = transform.Find("watch-4").gameObject;
		model2 = transform.Find("watch-3").gameObject;
		model3 = transform.Find("watch-1").gameObject;

		//model1.GetComponent<GameObject>().enabled = true;
		model1.SetActive(true);
		model2.SetActive(false);
		model3.SetActive(false);

		Previous.onClick.AddListener(prev);
		Next.onClick.AddListener(next);



		//model1.enabled = true;
		//model2.enabled = false;
		//model3.enabled = false;
		
		
		
	}

	public void prev()
	{
		if(model3.activeSelf == true)
		{
			model3.SetActive(false);
			model2.SetActive(true);
		}
		else if(model2.activeSelf == true)
		{
			model2.SetActive(false);
			model1.SetActive(true);
		}
	}

	public void next()
	{
		if(model1.activeSelf == true)
		{
			model1.SetActive(false);
			model2.SetActive(true);
		}
		else if(model2.activeSelf == true)
		{
			model2.SetActive(false);
			model3.SetActive(true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
