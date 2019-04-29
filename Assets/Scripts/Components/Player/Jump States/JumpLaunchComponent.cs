using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct JumpLaunch:IComponentData{
    public float Value;
  }
  public class JumpLaunchComponent : ComponentDataProxy<JumpLaunch>{}
}