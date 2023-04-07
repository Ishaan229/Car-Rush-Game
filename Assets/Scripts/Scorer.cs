using UnityEngine;
using TMPro;

public class Scorer : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    private float counterValue = 0;

    void Start()
    {
        InvokeRepeating("IncreaseCounter", 0.5f, 0.5f);
    }

    void Update()
    {
        counterText.text = counterValue.ToString();
    }

    void IncreaseCounter()
    {
        counterValue += 1;
    }
}
