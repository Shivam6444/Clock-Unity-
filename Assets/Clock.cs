using System;
using UnityEngine;
public class Clock : MonoBehaviour{ 
    public Transform hoursTransform, minutesTransform, secondsTransform;
    public bool continuous;
    const float degreesPerHour = 30f, degreesPerMin = 6f, degreesPerSec = 6f;
    private void Update(){
        //Debug.Log(DateTime.Now);
        if (continuous){
            UpdateContinuous();
        }
        else{
            UpdateDiscrete();
        }
    }
    public void UpdateDiscrete(){
        DateTime currTime = DateTime.Now;
        hoursTransform.localRotation = Quaternion.Euler(0f, currTime.Hour * degreesPerHour, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, currTime.Minute * degreesPerMin, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, currTime.Second * degreesPerSec, 0f);
    }

    public void UpdateContinuous(){
        TimeSpan currTime = DateTime.Now.TimeOfDay;
        hoursTransform.localRotation = Quaternion.Euler(0f, (float)currTime.TotalHours * degreesPerHour, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, (float)currTime.TotalMinutes * degreesPerMin, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, (float)currTime.TotalSeconds * degreesPerSec, 0f);
    }

}
