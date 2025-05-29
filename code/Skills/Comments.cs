using System;

namespace Skills;

public class Comments
{
// create a method that generates a comment for a given skill
    public string GenerateComment(string skillName, int skillLevel)
    {
        if (skillLevel < 1 || skillLevel > 5)
        {
            throw new ArgumentOutOfRangeException(nameof(skillLevel), "Skill level must be between 1 and 5.");
        }

        return $"The skill '{skillName}' is rated at level {skillLevel}.";
    }
}
