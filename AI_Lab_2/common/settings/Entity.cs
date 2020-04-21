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
        private double radius;
        private double angle;
        public Entity(string name, params EntityCharacteristics[] entityCharacteristics)
        {
            this.name = name;

            foreach (EntityCharacteristics entityChar in entityCharacteristics)
            {
                this.entityCharacteristics.Add(entityChar);
            }

        }
        public string Name { get => name; set => name = value; }
        public List<EntityCharacteristics> EntityCharacteristics { get => entityCharacteristics; set => entityCharacteristics = value; }
        public double Radius { get => radius; set => radius = value; }
        public double Angle { get => angle; set => angle = value; }
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
        public override string ToString()
        {
            string output = "";
            output += $"name: {this.name}" + Environment.NewLine;
            output += "{" + Environment.NewLine;
            foreach (EntityCharacteristics entityCharacteristics in this.entityCharacteristics)
            {
                output += $"\tname: {entityCharacteristics.Name}" + Environment.NewLine +
                    $"\tvalue: {entityCharacteristics.Value}" + Environment.NewLine;
            }
            output += "}" + Environment.NewLine;
            return output;
        }
        public double[] GetCoords()
        {
            double[] coords = new double[this.entityCharacteristics.Count()];
            for (int i = 0; i < this.entityCharacteristics.Count(); i++)
            {
                coords[i] = entityCharacteristics[i].Value;
            }
            return coords;
        }
    }
}
