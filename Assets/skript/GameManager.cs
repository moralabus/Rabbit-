using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int coinCount;
    public int CoinCount
    {
        get { return coinCount; }
        set
        {
            coinCount = value;

            // Проверить, собраны ли все монеты.
            if (coinCount >= 3)
            {
                // Открыть выход.
                OpenExit();
            }
        }
    }

    public void AddCoin()
    {
        CoinCount++;
    }

    public void OpenExit()
    {
        // Найти объект выхода и сделать его активным.
        GameObject exit = GameObject.Find("Exit");
        if (exit != null)
        {
            exit.SetActive(true);
        }
    }
}

