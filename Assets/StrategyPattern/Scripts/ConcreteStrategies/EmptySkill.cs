// Using for Debug.Log.
using UnityEngine;

public class EmptySkill : ISkill
{
    public void Use()
    {
        Debug.Log("No skill selected.");
    }
}
