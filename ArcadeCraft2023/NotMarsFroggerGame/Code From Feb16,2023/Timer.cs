using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider slider;
	//public Gradient gradient;
	public Image fill;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetMaxTimer(float timer)
	{
		slider.maxValue = timer;
		slider.value = timer;

		//fill.color = gradient.Evaluate(1f);
	}

	public void SetTimer(float timer)
	{
		slider.value = timer;

		//fill.color = gradient.Evaluate(slider.normalizedValue);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
