using AI_Lab_2.common.settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Lab_2.common.home
{
    class Home
    {
        private List<Entity> entities;
        public delegate double Operation(Entity enteredEntity, Entity establishedEntity);
        public Home(List<Entity> entities)
        {
            this.entities = entities;
        }

        public List<EntityOutput> Execute(Operation operation, Entity enteredEntity)
        {
            List<EntityOutput> results = new List<EntityOutput>();

            for (int i = 0; i < entities.Count; i++)
            {
                EntityOutput entityOutput = new EntityOutput();
                entityOutput.Name = entities[i].Name;
                entityOutput.Value = operation(enteredEntity, entities[i]);
                results.Add(entityOutput);
            }

            return results;
        }

    }
}
