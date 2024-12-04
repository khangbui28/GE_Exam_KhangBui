using System;
using UnityEngine;


public class HealthManager : MonoBehaviour
{
    public static Action<int> OnHealthUpdated;

    public static void HealthUpdated(int health)
    {
        OnHealthUpdated?.Invoke(health);
    }
}
