using UnityEngine;
using UnityEngine.UI;

public class DinoWinTrigger : MonoBehaviour
{
    public Text winText;

    private void Start()
    {
        if (winText != null)
        {
            winText.text = "";
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "player")
        {
            winText.text = "WIN!";
        }
    }
}