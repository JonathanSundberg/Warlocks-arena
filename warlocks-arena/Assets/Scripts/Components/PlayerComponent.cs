using Unity.Transforms;
using Unity.Entities;
[GenerateAuthoringComponent]
public struct PlayerComponent : IComponentData
{
    public Entity Prefab;
    public Translation SpawnPos;

}
