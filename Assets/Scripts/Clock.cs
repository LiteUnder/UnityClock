using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    private Transform hoursTransform, minutesTransform, secondsTransform;

    private const float degreesPerHour = 30f;
    private const float degreesPerMinute = 6f;
    private const float degreesPerSecond = 6f;

    void Start()
    {
        Debug.Log(DateTime.Now);
    }

    // Update is called once per frame
    void Update()
    {
        // current time since beginning of day
        var time = DateTime.Now.TimeOfDay;

        hoursTransform.localRotation = Quaternion.Euler(0, (float)time.TotalHours * degreesPerHour, 0);
        minutesTransform.localRotation = Quaternion.Euler(0, (float)time.TotalMinutes * degreesPerMinute, 0);
        secondsTransform.localRotation = Quaternion.Euler(0, (float)time.TotalSeconds * degreesPerSecond, 0);
    }
}
