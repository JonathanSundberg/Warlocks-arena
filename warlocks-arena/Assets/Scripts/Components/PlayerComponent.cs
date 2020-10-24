using Unity.Transforms;
using Unity.Entities;
using Unity.Core;

[GenerateAuthoringComponent]
public struct PlayerComponent : IComponentData
{
    public Entity Prefab;
}
