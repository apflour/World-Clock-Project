using UnityEngine;

public class WorldClockManager : MonoBehaviour {

    public GameObject clockPrefab;
    
    void Start() {
        
        // Instantiate LA clock
        GameObject losAngelesClock = Instantiate(clockPrefab, new Vector3(-15, 8, 0), Quaternion.identity);
        losAngelesClock.name = "Los Angeles";
        Clock losAngelesClockScript = losAngelesClock.GetComponent<Clock>();
        if (losAngelesClockScript != null)
        {
            losAngelesClockScript.timeZoneOffset = -7; 
            losAngelesClockScript.text = "Los Angeles";
        }

        // Instantiate New York clock
        GameObject newYorkClock = Instantiate(clockPrefab, new Vector3(0, 8, 0), Quaternion.identity);
        newYorkClock.name = "New York";
        Clock newYorkClockScript = newYorkClock.GetComponent<Clock>();
        if (newYorkClockScript != null)
        {
            newYorkClockScript.timeZoneOffset = -4;
            newYorkClockScript.text = "New York";

        }
        
        // Instantiate Iceland clock
        GameObject icelandClock = Instantiate(clockPrefab, new Vector3(15, 8, 0), Quaternion.identity);
        icelandClock.name = "Iceland";
        Clock icelandClockScript = icelandClock.GetComponent<Clock>();
        if (icelandClockScript != null)
        {
            icelandClockScript.timeZoneOffset = 0;
            icelandClockScript.text = "Iceland";

        }

        // Instantiate London clock
        GameObject londonClock = Instantiate(clockPrefab, new Vector3(-15, -5, 0), Quaternion.identity);
        londonClock.name = "London";
        Clock londonClockScript = londonClock.GetComponent<Clock>();
        if (londonClockScript != null)
        {
            londonClockScript.timeZoneOffset = +1;
            londonClockScript.text = "London";
        }

        // Instantiate Paris clock
        GameObject parisClock = Instantiate(clockPrefab, new Vector3(0, -5, 0), Quaternion.identity);
        parisClock.name = "Paris";
        Clock parisClockScript = parisClock.GetComponent<Clock>();
        if (parisClockScript != null)
        {
            parisClockScript.timeZoneOffset = +2;
            parisClockScript.text = "Paris";
        }

        // Instantiate Japan clock
        GameObject japanClock = Instantiate(clockPrefab, new Vector3(15, -5, 0), Quaternion.identity);
        japanClock.name = "Japan";
        Clock japanClockScript = japanClock.GetComponent<Clock>();
        if (japanClockScript != null)
        {
            japanClockScript.timeZoneOffset = +9;
            japanClockScript.text = "Japan";
        }
    }
}