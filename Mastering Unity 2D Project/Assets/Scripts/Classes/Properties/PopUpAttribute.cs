using UnityEngine;
public class PopUpAttribute: PropertyAttribute
{
  public string[] value;
  public PopUpAttribute(params string[] input)
  {
    value = input;
  }
}
