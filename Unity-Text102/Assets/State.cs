using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
  // Text area numerals set the min and max hight of the unity text box before adding a scroll bar
  [TextArea(10,14)] [SerializeField] string storyText;
  
}
