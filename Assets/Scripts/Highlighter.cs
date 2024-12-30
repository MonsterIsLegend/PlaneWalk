using DefaultNamespace;
using UnityEngine;

public class Highlighter : MonoBehaviour
{
    private Outline outline;
    private AdditionalOutline additionalOutline;

    public PromptSetter promptSetter;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.collider.TryGetComponent(out Outline outline))
            {
                if (this.outline != outline)
                {
                    DisableOutline();
                }

                if (hit.collider.TryGetComponent(out AdditionalOutline additionalOutline))
                {
                    this.additionalOutline = additionalOutline;
                    additionalOutline.SetOutlines(true);
                }

                if (hit.collider.TryGetComponent(out PromptValues values))
                {
                    promptSetter.SetPrompt(values.header, values.desc);
                }

                this.outline = outline;
                outline.enabled = true;
            }
            else
            {
                DisableOutline();
            }
        }
        else
        {
            DisableOutline();
        }
    }

    private void DisableOutline()
    {
        if (outline != null)
        {
            outline.enabled = false;
            promptSetter.ClosePrompt();
        }

        if (additionalOutline != null)
        {
            additionalOutline.SetOutlines(false);
        }
    }
}