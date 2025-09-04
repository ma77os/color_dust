using UnityEngine;
using UnityEngine.VFX;

public class TapReset : MonoBehaviour
{
    public VisualEffect vfx;

    void Update()
    {
        if (Input.GetMouseButtonUp(0) || Input.GetKeyUp(KeyCode.Space))
        {
            ResetVFX();
        }

    }

    void ResetVFX()
    {
        if (vfx == null)
            return;

        vfx.Reinit();
    }
}
