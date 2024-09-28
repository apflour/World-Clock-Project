using System;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour 
{
	
    public int timeZoneOffset = 0;
	public TextMeshPro Location;
	public string text = "";

	[SerializeField]
	Transform hoursPivot, minutesPivot, secondsPivot;


	private const float hoursToDegrees = -30f,
	minutesToDegrees = -6f, 
	secondsToDegrees = -6f;

	void Update()
	{
		Location.text = text;
		UpdateClock();		
	}
	
	void UpdateClock () {
		
		DateTime time = DateTime.UtcNow.AddHours(timeZoneOffset);
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * ((float)time.Hour + (float)time.Minute/60f));
		minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.Minute);
		secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.Second);
	}
}