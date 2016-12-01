using UnityEngine;
public class Npc : MonoBehaviour
{
    public string Name;
    [Range(0,100)]
    public int Age;
	[PopUp("Good Guy", "Independent", "Bad Guy")]
    public string Faction;
	[PopUp("Mayor", "Shopkeep", "Layabout")]
    public string Occupation;
	[Range(0,10)]
    public int Level;
}
