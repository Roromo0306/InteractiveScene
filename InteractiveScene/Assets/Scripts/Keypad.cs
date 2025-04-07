using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using TMPro.EditorUtilities;

public class Keypad : MonoBehaviour
{
    [SerializeField] private TMP_Text Ans;

    private string Answer = "25879";

    public GameObject door;
    // Start is called before the first frame update
   public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        if(Ans.text == Answer)
        {
            Ans.text = "Correct";
            door.SetActive(false);
        }
        else
        {
            Ans.text = "Invalid";
        }
    }
}
