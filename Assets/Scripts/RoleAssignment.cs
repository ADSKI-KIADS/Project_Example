using UnityEngine;
using UnityEngine.UI;

public class RoleAssignment : MonoBehaviour
{
    public Button randomAssignButton;
    public Button manualAssignButton;

    void Start()
    {
        randomAssignButton.onClick.AddListener(OnRandomAssign);
        manualAssignButton.onClick.AddListener(OnManualAssign);
    }

    void OnRandomAssign()
    {
        // TODO: Randomly assign each of the four roles to connected players
        Debug.Log("Random role assignment triggered.");
    }

    void OnManualAssign()
    {
        // TODO: Open UI for players to manually select roles
        Debug.Log("Manual role selection triggered.");
    }
}
