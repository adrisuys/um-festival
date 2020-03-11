using TMPro;
using UnityEngine;

public class NumberPicker : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    public int number;

    private void Start()
    {
        number = 0;
        numberText.text = number.ToString();
    }

    public void Plus()
    {
        number++;
        numberText.text = number.ToString();
    }

    public void Minus()
    {
        if (number == 0) return;
        number--;
        numberText.text = number.ToString();
    }

    public int GetValue()
    {
        return number;
    }
}
