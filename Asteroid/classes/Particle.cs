using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Geometry;

namespace Asteroid
{
    struct Particle
    {
        public Point3d Position { get; set; }
        public double Mass { get; set; }

        public Particle(Point3d position, double mass)
        {
            this.Position = position;
            this.Mass = mass;
        }

        public override string ToString()
        {
            return $"Particle(Position: ({this.Position.X}, {this.Position.Y}, {this.Position.Z}), Mass: {this.Mass})";
        }
    }
}
