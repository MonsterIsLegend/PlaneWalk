using TMPro;
using UnityEngine;

public class PromptSetter : MonoBehaviour
{
   public TextMeshProUGUI promptTextHeader;
   public TextMeshProUGUI promptTextDesc;
   public GameObject promptObject;

   public void SetPrompt(string header, string desc)
   {
      promptTextHeader.text = header;
      promptTextDesc.text = desc;
      promptObject.SetActive(true);
   }

   public void ClosePrompt()
   {
      promptObject.SetActive(false);
   }
}
