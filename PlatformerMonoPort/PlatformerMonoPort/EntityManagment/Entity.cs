using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
namespace PlatformerMonoPort
{
    public abstract class Entity : PlatformerMonoPort.EntityManagment.IEntity
    {
        GameXEntity worldIBelongTo;
        int myUniqueID;
        
        Vector2 position;

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public GameXEntity WorldIBelongTo
        {
            get { return worldIBelongTo; }
            set { worldIBelongTo = value; }
        }

        public int MyUniqueID
        {
            get { return myUniqueID; }
            set { myUniqueID = value; }
        }

        public Entity(int UniqueID)
        {
            
            MyUniqueID = UniqueID;
            position = new Vector2();
        }
        public Entity()
        {

        }

        public virtual void Update()
        {

        }
    }
}
