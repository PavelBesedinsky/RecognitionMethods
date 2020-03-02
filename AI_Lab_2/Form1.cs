using AI_Lab_2.common.home;
using AI_Lab_2.common.settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Entity> entities = new List<Entity>();
            entities.Add(new Entity("AR", new EntityCharacteristics[] { new EntityCharacteristics("Mass", 3300), new EntityCharacteristics("Length", 940), new EntityCharacteristics("Rate of fire", 600), new EntityCharacteristics("Volume", 30) }));
            entities.Add(new Entity("SMG", new EntityCharacteristics[] { new EntityCharacteristics("Mass", 2540), new EntityCharacteristics("Length", 680), new EntityCharacteristics("Rate of fire", 800), new EntityCharacteristics("Volume", 30) }));
            entities.Add(new Entity("MG", new EntityCharacteristics[] { new EntityCharacteristics("Mass", 6500), new EntityCharacteristics("Length", 1000), new EntityCharacteristics("Rate of fire", 900), new EntityCharacteristics("Volume", 100) }));
            entities.Add(new Entity("HG", new EntityCharacteristics[] { new EntityCharacteristics("Mass", 625), new EntityCharacteristics("Length", 186), new EntityCharacteristics("Rate of fire", 200), new EntityCharacteristics("Volume", 17) }));

            Home home = new Home(entities);

            Entity enteredEntity = new Entity("Uzi", new EntityCharacteristics[] { new EntityCharacteristics("Mass", 2650), new EntityCharacteristics("Length", 360), new EntityCharacteristics("Rate of fire", 1000), new EntityCharacteristics("Volume", 32) });

            List<EntityOutput> euclid =     home.Execute(Operations.Euclid, enteredEntity);
            List<EntityOutput> minkowski =  home.Execute(Operations.Minkowski, enteredEntity);
            List<EntityOutput> manhattan =  home.Execute(Operations.Manhattan, enteredEntity);
            List<EntityOutput> canberra =   home.Execute(Operations.Canberra, enteredEntity);

            string euclidResult =       enteredEntity.Name + " according to Euclid refers to " + DefineClassB(euclid).Name + Environment.NewLine;
            string minkowskiResult =    enteredEntity.Name + " according to Minkowski refers to " + DefineClassB(minkowski).Name + Environment.NewLine;
            string manhattanResult =    enteredEntity.Name + " according to Manhattan refers to " + DefineClassB(manhattan).Name + Environment.NewLine;
            string canberraResult =     enteredEntity.Name + " according to Canberra refers to " + DefineClassB(canberra).Name + Environment.NewLine;

            MessageBox.Show(euclidResult + minkowskiResult + manhattanResult + canberraResult);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            List<Entity> entities2 = new List<Entity>();
            entities2.Add(new Entity("Ballon", new EntityCharacteristics[]      { new EntityCharacteristics("Ability to fly", 1), new EntityCharacteristics("Control elements", 0), new EntityCharacteristics("Able to lift heavy loads", 0), new EntityCharacteristics("Piston engine", 0), new EntityCharacteristics("Turbojet engine", 0), new EntityCharacteristics("Turboprop engine", 0), new EntityCharacteristics("Gas turbine engine", 0), new EntityCharacteristics("Rocket engine", 0), new EntityCharacteristics("Main rotor", 0), new EntityCharacteristics("Height limit", 1) }));
            entities2.Add(new Entity("Helicopter", new EntityCharacteristics[]  { new EntityCharacteristics("Ability to fly", 1), new EntityCharacteristics("Control elements", 1), new EntityCharacteristics("Able to lift heavy loads", 1), new EntityCharacteristics("Piston engine", 1), new EntityCharacteristics("Turbojet engine", 0), new EntityCharacteristics("Turboprop engine", 0), new EntityCharacteristics("Gas turbine engine", 1), new EntityCharacteristics("Rocket engine", 0), new EntityCharacteristics("Main rotor", 1), new EntityCharacteristics("Height limit", 1) }));
            entities2.Add(new Entity("Airplane", new EntityCharacteristics[]    { new EntityCharacteristics("Ability to fly", 1), new EntityCharacteristics("Control elements", 1), new EntityCharacteristics("Able to lift heavy loads", 1), new EntityCharacteristics("Piston engine", 1), new EntityCharacteristics("Turbojet engine", 1), new EntityCharacteristics("Turboprop engine", 1), new EntityCharacteristics("Gas turbine engine", 0), new EntityCharacteristics("Rocket engine", 1), new EntityCharacteristics("Main rotor", 0), new EntityCharacteristics("Height limit", 1) }));
            entities2.Add(new Entity("Rocket", new EntityCharacteristics[]      { new EntityCharacteristics("Ability to fly", 1), new EntityCharacteristics("Control elements", 1), new EntityCharacteristics("Able to lift heavy loads", 1), new EntityCharacteristics("Piston engine", 0), new EntityCharacteristics("Turbojet engine", 0), new EntityCharacteristics("Turboprop engine", 0), new EntityCharacteristics("Gas turbine engine", 0), new EntityCharacteristics("Rocket engine", 0), new EntityCharacteristics("Main rotor", 0), new EntityCharacteristics("Height limit", 0) }));
            entities2.Add(new Entity("Earthbound", new EntityCharacteristics[]  { new EntityCharacteristics("Ability to fly", 0), new EntityCharacteristics("Control elements", 1), new EntityCharacteristics("Able to lift heavy loads", 0), new EntityCharacteristics("Piston engine", 1), new EntityCharacteristics("Turbojet engine", 0), new EntityCharacteristics("Turboprop engine", 0), new EntityCharacteristics("Gas turbine engine", 1), new EntityCharacteristics("Rocket engine", 0), new EntityCharacteristics("Main rotor", 0), new EntityCharacteristics("Height limit", 1) }));

            Home home2 = new Home(entities2);

            //Entity enteredEntity2 = new Entity("Boeing 737", new EntityCharacteristics[] { new EntityCharacteristics("Ability to fly", 1), new EntityCharacteristics("Control elements", 1), new EntityCharacteristics("Able to lift heavy loads", 1), new EntityCharacteristics("Piston engine", 0), new EntityCharacteristics("Turbojet engine", 1), new EntityCharacteristics("Turboprop engine", 0), new EntityCharacteristics("Gas turbine engine", 0), new EntityCharacteristics("Rocket engine", 0), new EntityCharacteristics("Main rotor", 0), new EntityCharacteristics("Height limit", 1) });
            //Entity enteredEntity2 = new Entity("BMW anyM", new EntityCharacteristics[] { new EntityCharacteristics("Ability to fly", 0), new EntityCharacteristics("Control elements", 1), new EntityCharacteristics("Able to lift heavy loads", 0), new EntityCharacteristics("Piston engine", 1), new EntityCharacteristics("Turbojet engine", 0), new EntityCharacteristics("Turboprop engine", 0), new EntityCharacteristics("Gas turbine engine", 0), new EntityCharacteristics("Rocket engine", 0), new EntityCharacteristics("Main rotor", 0), new EntityCharacteristics("Height limit", 1) });
            Entity enteredEntity2 = new Entity("Mil Mi-8", new EntityCharacteristics[] { new EntityCharacteristics("Ability to fly", 1), new EntityCharacteristics("Control elements", 1), new EntityCharacteristics("Able to lift heavy loads", 1), new EntityCharacteristics("Piston engine", 0), new EntityCharacteristics("Turbojet engine", 0), new EntityCharacteristics("Turboprop engine", 0), new EntityCharacteristics("Gas turbine engine", 1), new EntityCharacteristics("Rocket engine", 0), new EntityCharacteristics("Main rotor", 1), new EntityCharacteristics("Height limit", 1) });

            List<EntityOutput> raccel =     home2.Execute(Operations.RasselAndRao, enteredEntity2);
            List<EntityOutput> dice =       home2.Execute(Operations.Dice, enteredEntity2);
            List<EntityOutput> jul =        home2.Execute(Operations.Jul, enteredEntity2);
            List<EntityOutput> hammingau =  home2.Execute(Operations.Hammingau, enteredEntity2);

            string raccelResult =       enteredEntity2.Name + " according to RasselAndRao refers to " + DefineClassL(raccel).Name + Environment.NewLine;
            string diceResult =         enteredEntity2.Name + " according to Dice refers to " + DefineClassL(dice).Name + Environment.NewLine;
            string julResult =          enteredEntity2.Name + " according to Jul refers to " + DefineClassL(jul).Name + Environment.NewLine;
            string hammingauResult =    enteredEntity2.Name + " according to Hammingau refers to " + DefineClassB(hammingau).Name + Environment.NewLine;

            MessageBox.Show(raccelResult + diceResult + julResult + hammingauResult);
        }

        EntityOutput DefineClassB(List<EntityOutput> values)
        {
            EntityOutput minEntity = new EntityOutput();
            minEntity.Value = Double.MaxValue;
            foreach (EntityOutput entity in values)
            {
                if (minEntity.Value > entity.Value)
                {
                    minEntity = entity;
                }
            }
            return minEntity;
        }
        EntityOutput DefineClassL(List<EntityOutput> values)
        {
            EntityOutput maxEntity = new EntityOutput();
            maxEntity.Value = Double.MinValue;
            foreach (EntityOutput entity in values)
            {
                if (maxEntity.Value < entity.Value)
                {
                    maxEntity = entity;
                }
            }
            return maxEntity;
        }
    }
}
