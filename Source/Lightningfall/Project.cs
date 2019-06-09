using System.Collections.Generic;

namespace Lightningfall
{
    public class Project : Task, IProject
    {
        public Project(string name) : base(name)
        {
        }
    }
}