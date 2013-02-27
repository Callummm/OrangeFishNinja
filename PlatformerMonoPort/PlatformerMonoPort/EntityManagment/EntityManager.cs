using System.Collections.Generic;
using PlatformerMonoPort.EntityManagment;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
namespace PlatformerMonoPort
{
    
    public class EntityManager
    {
        private List<TestEntity> _activeEntities;
        int _nextId;
        GameXEntity _entityWorld;
        int _totalEntityAmount;
        private GraphicsDevice graphicsDevice;
        private ContentManager contentManager;
        private SpriteBatch spriteBatch;


        public EntityManager(GameXEntity pEntityWorld, GraphicsDevice pGraphicsDevice, ContentManager pContentManager, SpriteBatch pSpriteBatch )
        {
            ActiveEntities = new List<TestEntity>();
            _entityWorld = pEntityWorld;
            _totalEntityAmount = 0;
            graphicsDevice = pGraphicsDevice;
            contentManager = pContentManager;
            spriteBatch = pSpriteBatch;
            _nextId = 0;
        }

        public List<TestEntity> ActiveEntities
        {
            get { return _activeEntities; }
            set { _activeEntities = value; }
        }

        public Entity CreateEntity()
        {
            TestEntity createdEntity = new TestEntity(_nextId++, graphicsDevice,contentManager,spriteBatch);
            
            ActiveEntities.Add(createdEntity);
            _totalEntityAmount++;

            return createdEntity;
        }


        public void RemoveEntityById(int pEntityId)
        {
            ActiveEntities.RemoveAt(pEntityId - 1);
            _totalEntityAmount--;
        }

        public Entity GetEntityById(int pEntityId)
        {
            return ActiveEntities[pEntityId - 1];
        }

        public List<TestEntity> GetAllEntities()
        {
            return ActiveEntities;
        }

        public void UpdateAllEntities()
        {
            foreach (TestEntity TE in ActiveEntities)
            {
                TE.Update();

            }

        }

    }
}
