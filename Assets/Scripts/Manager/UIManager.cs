using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI healthText;

    public static UIManager instance;

    public static UIManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindAnyObjectByType<UIManager>();
                if (instance == null)
                {
                    GameObject obj = new GameObject(nameof(UIManager));
                    instance = obj.AddComponent<UIManager>();
                }
            }
            return instance;
        }
    }
    private void OnEnable()
    {
        HealthManager.OnHealthUpdated += UpdateHealth;
    }

    private void OnDisable()
    {
        HealthManager.OnHealthUpdated -= UpdateHealth;
    }

    public void UpdateHealth(int health)
    {
        healthText.text = health.ToString();
    }
}
