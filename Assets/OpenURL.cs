using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public string url = "https://assetstore.unity.com/packages/2d/characters/sunny-land-103349"; // เปลี่ยนลิงก์ตามต้องการ

    public void OpenWebsite()
    {
        Application.OpenURL(url);
    }
}
