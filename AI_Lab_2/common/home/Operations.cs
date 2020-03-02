using AI_Lab_2.common.settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Lab_2.common.home
{
    static class Operations
    {
        public static double Euclid(Entity enteredEntity, Entity establishedEntity)
        {
            double entitiesSum = 0;
            for (int i = 0; i < establishedEntity.length(); i++)
            {
                entitiesSum += Math.Pow(enteredEntity.getEntityCharacteristicsValue(i) - establishedEntity.getEntityCharacteristicsValue(i), 2);
            }
            return Math.Sqrt(entitiesSum);
        }
        public static double Minkowski(Entity enteredEntity, Entity establishedEntity)
        {
            int alpha = 4;
            double entitiesSum = 0;
            for (int i = 0; i < establishedEntity.length(); i++)
            {
                entitiesSum += Math.Pow(enteredEntity.getEntityCharacteristicsValue(i) - establishedEntity.getEntityCharacteristicsValue(i), alpha);
            }
            return Math.Pow(entitiesSum, 1.0 / alpha);
        }
        public static double Manhattan(Entity enteredEntity, Entity establishedEntity)
        {
            double entitiesSum = 0;
            for (int i = 0; i < establishedEntity.length(); i++)
            {
                entitiesSum += Math.Abs(enteredEntity.getEntityCharacteristicsValue(i) - establishedEntity.getEntityCharacteristicsValue(i));
            }
            return entitiesSum;
        }
        public static double Canberra(Entity enteredEntity, Entity establishedEntity)
        {
            double entitiesSum = 0;
            for (int i = 0; i < establishedEntity.length(); i++)
            {
                entitiesSum += Math.Abs(enteredEntity.getEntityCharacteristicsValue(i) - establishedEntity.getEntityCharacteristicsValue(i)) /
                    Math.Abs(enteredEntity.getEntityCharacteristicsValue(i) + establishedEntity.getEntityCharacteristicsValue(i));
            }
            return entitiesSum;
        }
        public static double RasselAndRao(Entity enteredEntity, Entity establishedEntity)
        {
            return SubOperations.a(enteredEntity, establishedEntity) / 
                (SubOperations.a(enteredEntity, establishedEntity) + SubOperations.b(enteredEntity, establishedEntity) + SubOperations.g(enteredEntity, establishedEntity) + SubOperations.h(enteredEntity, establishedEntity));
        }
        public static double Dice(Entity enteredEntity, Entity establishedEntity)
        {
            return SubOperations.a(enteredEntity, establishedEntity) / (2 * SubOperations.a(enteredEntity, establishedEntity) + SubOperations.g(enteredEntity, establishedEntity) + SubOperations.h(enteredEntity, establishedEntity)); 
        }
        public static double Jul(Entity enteredEntity, Entity establishedEntity)
        {
            return (SubOperations.a(enteredEntity, establishedEntity) * SubOperations.b(enteredEntity, establishedEntity) - SubOperations.g(enteredEntity, establishedEntity) * SubOperations.h(enteredEntity, establishedEntity)) /
                (SubOperations.a(enteredEntity, establishedEntity) * SubOperations.b(enteredEntity, establishedEntity) + SubOperations.g(enteredEntity, establishedEntity) * SubOperations.h(enteredEntity, establishedEntity));
        }
        public static double Hammingau(Entity enteredEntity, Entity establishedEntity)
        {
            double entitiesSum = 0;
            for (int i = 0; i < establishedEntity.length(); i++)
            {
                entitiesSum += (enteredEntity.getEntityCharacteristicsValue(i) != establishedEntity.getEntityCharacteristicsValue(i)) ? 1 : 0;
            }
            return entitiesSum;
        }
    }
}
