using AI_Lab_2.common.home;
using AI_Lab_2.common.settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AI_Lab_2
{
    public partial class Form1 : Form
    {
        Entity enteredEntity;
        Home home;
        public Form1()
        {
            InitializeComponent();
        }
        EntityOutput DefineClassMin(List<EntityOutput> values)
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
        EntityOutput DefineClassMax(List<EntityOutput> values)
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
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                home = new Home(JsonConvert.DeserializeObject<List<Entity>>(Utils.ReadJson("../../resources/models/quantitiveModel.json")));
                enteredEntity = JsonConvert.DeserializeObject<Entity>(Utils.ReadJson());

                List<EntityOutput> euclid = home.Execute(Operations.Euclid, enteredEntity);
                List<EntityOutput> minkowski = home.Execute(Operations.Minkowski, enteredEntity);
                List<EntityOutput> manhattan = home.Execute(Operations.Manhattan, enteredEntity);
                List<EntityOutput> canberra = home.Execute(Operations.Canberra, enteredEntity);

                string euclidResult = enteredEntity.Name + " according to Euclid refers to " + DefineClassMin(euclid).Name + Environment.NewLine;
                string minkowskiResult = enteredEntity.Name + " according to Minkowski refers to " + DefineClassMin(minkowski).Name + Environment.NewLine;
                string manhattanResult = enteredEntity.Name + " according to Manhattan refers to " + DefineClassMin(manhattan).Name + Environment.NewLine;
                string canberraResult = enteredEntity.Name + " according to Canberra refers to " + DefineClassMin(canberra).Name + Environment.NewLine;

                rTB.Text = euclidResult + minkowskiResult + manhattanResult + canberraResult;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                home = new Home(JsonConvert.DeserializeObject<List<Entity>>(Utils.ReadJson("../../resources/models/qualitiveModel.json")));
                enteredEntity = JsonConvert.DeserializeObject<Entity>(Utils.ReadJson());

                List<EntityOutput> raccel = home.Execute(Operations.RasselAndRao, enteredEntity);
                List<EntityOutput> dice = home.Execute(Operations.Dice, enteredEntity);
                List<EntityOutput> jul = home.Execute(Operations.Jul, enteredEntity);
                List<EntityOutput> hammingau = home.Execute(Operations.Hammingau, enteredEntity);
                List<EntityOutput> ochiai = home.Execute(Operations.Ochiai, enteredEntity);

                string raccelResult = enteredEntity.Name + " according to RasselAndRao refers to " + DefineClassMax(raccel).Name + Environment.NewLine;
                string diceResult = enteredEntity.Name + " according to Dice refers to " + DefineClassMax(dice).Name + Environment.NewLine;
                string julResult = enteredEntity.Name + " according to Jul refers to " + DefineClassMax(jul).Name + Environment.NewLine;
                string hammingauResult = enteredEntity.Name + " according to Hammingau refers to " + DefineClassMin(hammingau).Name + Environment.NewLine;
                string ochiaiResult = enteredEntity.Name + " according to Ochiai refers to " + DefineClassMax(ochiai).Name + Environment.NewLine;

                rTB.Text = raccelResult + diceResult + julResult + hammingauResult + ochiaiResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                home = new Home(JsonConvert.DeserializeObject<List<Entity>>(Utils.ReadJson("../../resources/models/quantitiveModel.json")));
                enteredEntity = JsonConvert.DeserializeObject<Entity>(Utils.ReadJson());

                List<EntityOutput> acos = home.Execute(Operations.Arccos, enteredEntity);
                List<EntityOutput> smul = home.Execute(Operations.Smul, enteredEntity);
                List<EntityOutput> area = home.Execute(Operations.Area, enteredEntity);

                string acosResult = enteredEntity.Name + " according to Acos refers to " + DefineClassMin(acos).Name + Environment.NewLine;
                string smulResult = enteredEntity.Name + " according to Smul refers to " + DefineClassMax(smul).Name + Environment.NewLine;
                string areaResult = enteredEntity.Name + " according to Area refers to " + DefineClassMax(area).Name + Environment.NewLine;

                rTB.Text = acosResult + smulResult + areaResult;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
