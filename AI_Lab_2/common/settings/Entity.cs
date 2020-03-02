using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Lab_2.common.settings
{
    class Entity
    {
        private string name;
        private List<EntityCharacteristics> entityCharacteristics = new List<EntityCharacteristics>();

        public Entity(string name, params EntityCharacteristics[] entityCharacteristics)
        {
            this.name = name;
            
            foreach(EntityCharacteristics entityChar in entityCharacteristics)
            {
                this.entityCharacteristics.Add(entityChar);
            }

        }

        public string Name { get => name; set => name = value; }
        public double getEntityCharacteristicsValue(int identificator)
        {
            return entityCharacteristics[identificator].Value;
        }
        public double getEntityCharacteristicsValue(string fieldName)
        {
            foreach(EntityCharacteristics entity in entityCharacteristics)
            {
                try
                {


                    if (String.Compare(fieldName.ToUpper(), entity.Name.ToUpper()) == 1)
                    {
                        return entity.Value;
                    }
                    else
                    {
                        throw new Exception($"Value {fieldName} wasn't found!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                }

            }
            return double.NaN;
        }
        public EntityCharacteristics getEntityCharacteristics(int identificator)
        {
            return entityCharacteristics[identificator];
        }
        public EntityCharacteristics getEntityCharacteristics(string fieldName)
        {
            foreach (EntityCharacteristics entity in entityCharacteristics)
            {
                try
                {
                    if (String.Compare(fieldName.ToUpper(), entity.Name.ToUpper()) == 1)
                    {
                        return entity;
                    }
                    else
                    {
                        throw new Exception($"Value {fieldName} wasn't found!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                }

            }
            return null;
        }
        public int length()
        {
            return entityCharacteristics.Count();
        }
    }
}
