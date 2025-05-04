
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credit : MonoBehaviour
{
    public void GoToCredit()
    {
        SceneManager.LoadScene("CreditScene");
    }
}