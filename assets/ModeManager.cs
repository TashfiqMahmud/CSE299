using UnityEngine;

public class ModeManager : MonoBehaviour
{
    public enum Mode
    {
        NoTimer,
        Easy,
        Hard
    }

    public static Mode selectedMode = Mode.NoTimer; // default
}
