using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week06_futoszalag.Abstractions;

namespace Week06_futoszalag.Entities
{
    public class BallFactory : Abstractions.IToyFactory
    {
        public Abstractions.Toy CreateNew()
        {
            return new Ball();
        }
    }
}
