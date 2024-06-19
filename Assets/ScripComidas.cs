using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripComidas : MonoBehaviour
{
    public GameObject[] comidas;
    public int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentIndex < comidas.Length)
            {
                DeactivateAll();
                ActivateByIndex(currentIndex);
                currentIndex++;
            }
            else
            {
                currentIndex = 0;
                DeactivateAll();
                ActivateByIndex(currentIndex);
                currentIndex++;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            DeactivateAll();
            currentIndex--;
            if (currentIndex >= 0)
            {
                DeactivateAll();
                ActivateByIndex(currentIndex);
            }
            else
            {
                currentIndex = comidas.Length - 1;
                DeactivateAll();
                ActivateByIndex(currentIndex);
            }
        }
    }
    void DeactivateAll()
    {
        for (int i = 0; i < comidas.Length; i++)
        {
            comidas[i].SetActive(false);
        }
    }
    void ActivateByIndex(int index)
    {
        comidas[index].SetActive(true);
    }
}
