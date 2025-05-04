using TMPro; // ใช้ TextMesh Pro แทน
using UnityEngine;

public class DinoWinTrigger : MonoBehaviour
{
    public TextMeshProUGUI winText;

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