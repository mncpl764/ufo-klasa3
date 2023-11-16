using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class loopbg : MonoBehaviour
{
    private int limitPetli = 1000000;

    // Start is called before the first frame update
    void Start()
    {

        // Uruchom w¹tek w tle do wykonania pêtli
        Thread watekWtle = new Thread(MetodaPetliWTle);
        watekWtle.Start();

        // Wykonaj inne inicjalizacje w g³ównym w¹tku, jeœli to konieczne

    }

    // Update is called once per frame
    void MetodaPetliWTle()
    {
        for (int licznik = 0; licznik < limitPetli; licznik++)
        {
            // Tutaj umieœæ swoj¹ logikê pêtli

            // Przyk³ad: Zaloguj wartoœæ licznika do konsoli
            Debug.Log("Licznik: " + licznik);

            // Dodaj opóŸnienie, aby unikn¹æ wysokiego u¿ycia procesora
            Thread.Sleep(1);

        }
        UnityMainThreadDispatcher.Instance().Enqueue(() =>
        {
            Debug.Log("Petla w tle zakonczona");
        });
    }
}