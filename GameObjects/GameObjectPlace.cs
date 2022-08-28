using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.GameObjects
{
    public class GameObjectPlace
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public override bool Equals(object? obj)
        {
            GameObjectPlace objPlace = obj as GameObjectPlace;

            if (objPlace != null && 
                this.XCoordinate == objPlace.XCoordinate &&
                this.YCoordinate == objPlace.YCoordinate)
                return true;
            
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
