using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  [UpdateInGroup(typeof(MainSimulationSystemGroup))]
  public class JumpReleaseEndSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery(
        typeof(Player),
        typeof(JumpLaunch)
      );
    }

    protected override void OnUpdate () {
      if (!Input.GetButtonUp("Jump"))
        return;

      Entities.With(player).ForEach(entity => {
        PostUpdateCommands.RemoveComponent<JumpLaunch>(entity);
        PostUpdateCommands.AddComponent<JumpEnd>(entity, new JumpEnd { });
      });
    }
  }
}