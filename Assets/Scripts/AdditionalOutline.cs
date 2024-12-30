using System.Collections.Generic;
using UnityEngine;

public class AdditionalOutline : MonoBehaviour
{
    public List<Outline> outlines;


    public void SetOutlines(bool isActive)
    {
        foreach (Outline outline in outlines)
        {
            outline.enabled = isActive;
        }
    }
}
