using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
public class PlayerSpawner : ComponentSystem
{
    private float spawnTimer;
    private Random random;
   

    protected override void OnCreate()
    {
        random = new Random(10);
    }
    protected override void OnUpdate()
    {
        spawnTimer -= Time.DeltaTime;
        if(spawnTimer <= 0)
        {
            spawnTimer = .5f;
            Entities.ForEach((ref PlayerComponent player) =>
            {
                Entity spawnedEntity = EntityManager.Instantiate(player.Prefab);
                EntityManager.SetComponentData(spawnedEntity, new Translation { Value = player.spawnPos.Value });
            });
        }
    }
}
