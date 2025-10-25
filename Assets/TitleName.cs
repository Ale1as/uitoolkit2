using System;
using Mono.Cecil.Cil;
using UnityEngine;

[CreateAssetMenu(fileName = "TitleName", menuName = "Scriptable Objects/TitleName")]
public class TitleName : ScriptableObject
{
    public int health = 100;
}
