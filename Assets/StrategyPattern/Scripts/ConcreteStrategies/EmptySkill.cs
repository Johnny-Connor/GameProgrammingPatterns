using UnityEngine; // Using for Debug.Log.

public class EmptySkill : ISkill
{
    public void Use()
    {
        Debug.Log("No skill selected.");
    }
}
