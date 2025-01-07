using System.Diagnostics;
using UnityEngine;

public class LightSource : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.IndarknessState(false);
        print("count up");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameManager.Instance.IndarknessState(true);
        print("count down");
    }
}
