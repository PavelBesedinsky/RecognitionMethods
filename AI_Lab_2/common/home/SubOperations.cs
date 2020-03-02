using AI_Lab_2.common.settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Lab_2.common.home
{
    static class SubOperations
    {
        public static double a(Entity enteredEntity, Entity establishedEntity)
        {
            double entitiesSum = 0;
            for (int i = 0; i < establishedEntity.length(); i++)
            {
                entitiesSum += enteredEntity.getEntityCharacteristicsValue(i) * establishedEntity.getEntityCharacteristicsValue(i);
            }
            return entitiesSum;
        }
        public static double b(Entity enteredEntity, Entity establishedEntity)
        {
            double entitiesSum = 0;
            for (int i = 0; i < establishedEntity.length(); i++)
            {
                entitiesSum += (1 - enteredEntity.getEntityCharacteristicsValue(i)) * (1 - establishedEntity.getEntityCharacteristicsValue(i));
            }
            return entitiesSum;
        }
        public static double g(Entity enteredEntity, Entity establishedEntity)
        {
            double entitiesSum = 0;
            for (int i = 0; i < establishedEntity.length(); i++)
            {
                entitiesSum += (1 - enteredEntity.getEntityCharacteristicsValue(i)) * establishedEntity.getEntityCharacteristicsValue(i);
            }
            return entitiesSum;
        }
        public static double h(Entity enteredEntity, Entity establishedEntity)
        {
            double entitiesSum = 0;
            for (int i = 0; i < establishedEntity.length(); i++)
            {
                entitiesSum += enteredEntity.getEntityCharacteristicsValue(i) * (1 - establishedEntity.getEntityCharacteristicsValue(i));
            }
            return entitiesSum;
        }
    }
}
