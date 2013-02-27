using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using PlatformerMonoPort.EntityManagment;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
namespace PlatformerMonoPort.EntityManagment
{
    public class TestEntity : GameXEntity
    {
        private GraphicsDevice graphicsDevice;
        private ContentManager contentManager;
        private SpriteBatch spriteBatch;
        Texture2D TestTexture;

        public TestEntity(int MyuniqueID, GraphicsDevice pGraphicsDevice, ContentManager pContentManager, SpriteBatch pSpriteBatch)
        {
            graphicsDevice = pGraphicsDevice;
            contentManager = pContentManager;
            spriteBatch = pSpriteBatch;
            //LoadContent();
            TestTexture = new Texture2D(graphicsDevice, 64, 64);
            LoadContent();
        }

        public void LoadContent()
        {
            TestTexture = contentManager.Load<Texture2D>("OrangeFish");
        }

        public void Draw()
        {
            
            spriteBatch.Draw(TestTexture, new Vector2(graphicsDevice.Viewport.Width / 2,graphicsDevice.Viewport.Height / 2), Color.White);
            

        }

        public override void Update()
        {
             Draw();
        }
    }
}
