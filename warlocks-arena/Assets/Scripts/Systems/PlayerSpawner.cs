using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
public class PlayerSpawner : ComponentSystem
{

    protected override void OnCreate()
    {
    }
    protected override void OnUpdate()
    {
        Entities.ForEach((ref PlayerComponent player) =>
        {
            Entity spawnedEntity = EntityManager.Instantiate(player.Prefab);
            EntityManager.SetComponentData(spawnedEntity, new Translation { Value = player.SpawnPos.Value });
        });

    }
}
