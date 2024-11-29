using UnityEngine;
using TMPro;
using UnityEditor.ShaderGraph.Internal;

public class ReaktorTimer : MonoBehaviour
{
    private float CurrentTime;
    [SerializeField] private float MaxTimer;
    [SerializeField] private TextMeshProUGUI ReaktorTimerText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentTime = MaxTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentTime > 0)
        {
            CurrentTime -= Time.deltaTime;
            float min = Mathf.FloorToInt(CurrentTime / 60);
            float sec = Mathf.FloorToInt(CurrentTime % 60);
            //print(sec);
            ReaktorTimerText.text = string.Format(min.ToString() + " : " + sec.ToString());
            //ReaktorTimerText.text = string.Format("{0:00} : {0:00}", min, sec);
        }
    }
}
