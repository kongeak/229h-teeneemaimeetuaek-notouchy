using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credit : MonoBehaviour
{
    public void Credit()
    {
        SceneManager.LoadScene("CreditScene"); // เปลี่ยนชื่อให้ตรงกับฉากจริง
    }
}
